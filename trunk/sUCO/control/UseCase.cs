using System;
using System.Collections.Generic;

namespace sUCO
{
    public class UseCase
    {
        private String              ucID;
        private String              eaID;
        private UseCaseType         type;
        private String              name;
        private int                 seqNumber;
        private int                 top;
        private int                 left;
        private int                 right;
        private int                 bottom;
        private int                 width;
        private int                 height;
        private IList<UserCaseLink> links;

        public enum UseCaseType
        {
            USE_CASE,
            ACTOR
        }

        public UseCase(String id, String name)
        {
            this.eaID = id;
            this.name = name;
            this.links = new List<UserCaseLink>();
        }

        public IList<UserCaseLink> Links
        {
            get { return this.links; }
            set { this.links = value; }
        }

        public String EaID
        {
            get { return this.eaID; }
            set { this.eaID = value; }
        }

        public String UcID
        {
            get { return this.ucID; }
            set { this.ucID = value; }
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

        public int Right
        {
            get { return this.right; }
            set { this.right = value; }
        }

        public int Bottom
        {
            get { return this.bottom; }
            set { this.bottom = value; }
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

        public UseCaseType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
    }
}
