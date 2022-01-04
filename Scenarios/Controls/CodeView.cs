using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using DotVVM.Framework.Binding;
using DotVVM.Framework.Controls;

namespace Scenarios.Controls
{
    public class CodeView : CompositeControl
    {

        public static DotvvmControl GetContents(string fileName)
        {
            var code = ParseCodeSnippet(fileName);

            return new HtmlGenericControl("pre")
                .AppendChildren(
                    new HtmlGenericControl("code")
                        .SetProperty(c => c.InnerText, code)
                );
        }

        private static readonly Regex DothtmlBeginSequence = new Regex(@"<%--\s*BEGIN\s*--%>");
        private static readonly Regex DothtmlEndSequence = new Regex(@"<%--\s*END\s*--%>");
        private static readonly Regex CsharpBeginSequence = new Regex(@"//\s*BEGIN");
        private static readonly Regex CsharpEndSequence = new Regex(@"//\s*END");

        private static string ParseCodeSnippet(string fileName)
        {
            var isDothtml = string.Equals(Path.GetExtension(fileName), ".dothtml", StringComparison.OrdinalIgnoreCase);
            var isCsharp = string.Equals(Path.GetExtension(fileName), ".cs", StringComparison.OrdinalIgnoreCase);

            var beginSequence = isDothtml ? DothtmlBeginSequence : isCsharp ? CsharpBeginSequence : null;
            var endSequence = isDothtml ? DothtmlEndSequence : isCsharp ? CsharpEndSequence : null;

            var fileContents = File.ReadAllText(fileName, Encoding.UTF8);

            // cut off begin or end sequence
            if (beginSequence != null)
            {
                var match = beginSequence.Match(fileContents);
                if (match.Success)
                {
                    fileContents = fileContents.Substring(match.Index + match.Length);
                }
            }

            if (endSequence != null)
            {
                var match = endSequence.Match(fileContents);
                if (match.Success)
                {
                    fileContents = fileContents.Substring(0, match.Index);
                }
            }

            // trim empty lines from the beginning and the end
            var lines = GetLines(fileContents).ToList();
            while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[0]))
            {
                lines.RemoveAt(0);
            }
            while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[^1]))
            {
                lines.RemoveAt(lines.Count - 1);
            }

            // trim common indentation for all lines
            var minIndent = lines
                .Where(l => !string.IsNullOrWhiteSpace(l))
                .Min(l => (int?)l.TakeWhile(char.IsWhiteSpace).Count()) ?? 0;
            var linesWithoutIndentation = lines
                .Select(l => l.Length >= minIndent ? l.Substring(minIndent) : l);

            return string.Join(Environment.NewLine, linesWithoutIndentation);
        }

        private static IEnumerable<string> GetLines(string fileContents)
        {
            using var sr = new StringReader(fileContents);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }
}

