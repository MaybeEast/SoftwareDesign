using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    interface INodeComponent
    {
        public float getValue();

        public void addChildren(INodeComponent a, INodeComponent b);
    }
}