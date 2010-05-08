using System;
using System.Collections.Generic;

namespace sUCO
{
    class UseCase
    {
        private String id;
        private String name;
        private IList<UserCaseLink> links;

        public UseCase(String id, String name)
        {
            this.id = id;
            this.name = name;
            this.links = new List<UserCaseLink>();
        }

        public IList<UserCaseLink> Links
        {
            get { return this.links; }
            set { this.links = value; }
        }

        public String Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
