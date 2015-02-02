using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuidGenerator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    Clipboard.SetText(Guid.NewGuid().ToString());
                    break;
                case 1:
                    var count = int.Parse(args[0]);
                    var result = new List<string>();
                    for (int i = 0; i < count; i++)
                        result.Add(Guid.NewGuid().ToString());
                    Clipboard.SetText(string.Join<string>(Environment.NewLine, result));
                    break;
                default:
                    break;
            }
        }
    }
}