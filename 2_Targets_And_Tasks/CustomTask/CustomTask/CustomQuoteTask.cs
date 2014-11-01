using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Build.Framework;

namespace CustomTask
{
    /*  Before creating your own custom task look for existing custom tasks at the following locations
     *  1.  http://mikefourie.github.io/MSBuildExtensionPack/
     *  2.  https://github.com/loresoft/msbuildtasks
     */
    public class CustomQuoteTask : ITask
    {
        public IBuildEngine BuildEngine
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Execute()
        {
            throw new NotImplementedException();
        }

        public ITaskHost HostObject
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
