using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class NodeLeaf : INodeComponent
    {
        float value = 0;

        public NodeLeaf(float value){
            this.value = value;
        }

        public float getValue(){
            return value;
        }

        public void addChildren(INodeComponent a, INodeComponent b){
            throw new NotImplementedException();
        }
    }

}