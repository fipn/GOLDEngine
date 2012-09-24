namespace GOLDEngine
{
    using System.ComponentModel;

    public class Reduction : TokenList
    {
        //================================================================================
        // Class Name:
        //      Reduction
        //
        // Instancing:
        //      Public; Creatable  (VB Setting: 2 - PublicNotCreatable)
        //
        // Purpose:
        //      This class is used by the engine to hold a reduced rule. Rather the contain
        //      a list of Symbols, a reduction contains a list of Tokens corresponding to the
        //      the rule it represents. This class is important since it is used to store the
        //      actual source program parsed by the Engine.
        //
        // Author(s):
        //      Devin Cook
        //
        // Dependacies:
        //================================================================================


        private Production m_Parent;

        private object m_Tag;
        internal Reduction(int Size)
            : base()
        {
            ReDimension(Size);
        }

        internal void ReDimension(int Size)
        {
            //Increase the size of the array to Size empty elements.
            int n = 0;

            base.Clear();
            for (n = 0; n <= Size - 1; n++)
            {
                base.Add(null);
            }
        }

        [Description("Returns the parent production.")]
        public Production Parent
        {
            get { return m_Parent; }
            internal set { m_Parent = value; }
        }

        [Description("Returns/sets any additional user-defined data to this object.")]
        public object Tag
        {
            get { return m_Tag; }
            set { m_Tag = value; }
        }
    }
}
