using System;
using System.Collections.Generic;

namespace sUCO
{
    public class UseCase
    {
        private String  id;
        private String  name;
        private int     seqNumber;
        private int     top;
        private int     left;
        private int     width;
        private int     height;

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

        public int SeqNumber
        {
            get { return this.seqNumber; }
            set { this.seqNumber = value; }
        }

        public int Top
        {
            get { return this.top; }
            set { this.top = value; }
        }

        public int Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
    }
}
