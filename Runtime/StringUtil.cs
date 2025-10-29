// Copyright 2025 Code Philosophy
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.Generic;
using System.Text;

namespace Luban
{
    public static class StringUtil
    {
        public static string ToStr(object o)
        {
            return ToStr(o, new StringBuilder());
        }

        public static string ToStr(object o, StringBuilder sb)
        {
            foreach (var p in o.GetType().GetFields())
            {

                sb.Append($"{p.Name} = {p.GetValue(o)},");
            }

            foreach (var p in o.GetType().GetProperties())
            {
                sb.Append($"{p.Name} = {p.GetValue(o)},");
            }
            return sb.ToString();
        }

        public static string ArrayToString<T>(T[] arr)
        {
            return "[" + string.Join(",", arr) + "]";
        }


        public static string CollectionToString<T>(IEnumerable<T> arr)
        {
            return "[" + string.Join(",", arr) + "]";
        }


        public static string CollectionToString<TK, TV>(IDictionary<TK, TV> dic)
        {
            var sb = new StringBuilder();
            sb.Append('{');
            foreach (var e in dic)
            {
                sb.Append(e.Key).Append(':');
                sb.Append(e.Value).Append(',');
            }
            sb.Append('}');
            return sb.ToString();
        }
    }
}
