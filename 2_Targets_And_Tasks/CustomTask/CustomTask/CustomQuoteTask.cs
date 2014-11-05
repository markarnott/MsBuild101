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
        private List<Quotation> FamousQuotes = new List<Quotation>();

        public CustomQuoteTask()
        {
            FamousQuotes.Add(new Quotation
            {
                Author = "Mark Twain",
                Saying = "Do the right thing. It will gratify some people and astonish the rest."
            } );
            FamousQuotes.Add(new Quotation
            {
                Author = "Mark Twain",
                Saying = "The secret of getting ahead is getting started."
            } );
            FamousQuotes.Add(new Quotation
            {
                Author = "Abraham Lincoln",
                Saying = "Give me six hours to chop down a tree and I will spend the first four sharpening the axe."
            });
            FamousQuotes.Add(new Quotation
            {
                Author = "Abraham Lincoln",
                Saying = "Most folks are as happy as they make up their minds to be."
            });
        }

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
