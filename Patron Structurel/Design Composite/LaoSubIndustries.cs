class LaoSubIndustries : LaoIndustries
    {
        protected List<LaoIndustries> _children = new List<LaoIndustries>();
        
        public override void Add(LaoIndustries component)
        {
            this._children.Add(component);
            
        }

        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";

            foreach (LaoIndustries component in this._children)
            {
                result += component.Operation();
                if (i != this._children.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            
            return result + ")";
        }
    }