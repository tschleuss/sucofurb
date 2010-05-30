using System;

namespace sUCO
{
    public class UserCaseLink
    {
        private String source;
        private String target;
        private String type;

        public UserCaseLink()
        {
        }

        public String Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        public String Target
        {
            get { return this.target; }
            set { this.target = value; }
        }

        public String Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
