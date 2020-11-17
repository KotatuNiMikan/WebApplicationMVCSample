using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GUITestSupport
{
    public class SolutionFilePathGetter
    {
        public string GetPath() 
        {
            var path = Directory.GetCurrentDirectory();
            while (Directory.Exists(path)) 
            {
                if (Directory.GetFiles(path).Any(file => file.EndsWith(".sln")))
                {
                    return path;
                }

                var parent = Directory.GetParent(path);
                if (parent == null)
                {
                    throw new Exception();
                }

                path = parent.FullName;
            }

            throw new Exception();
        }
    }
}
