using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class NodeComposite : INodeComponent
    {
        String arithmeticOperation;
        INodeComponent leftChild = null;
        INodeComponent rightChild = null;

        public NodeComposite(String arithmeticOperation){
            this.arithmeticOperation = arithmeticOperation;
        }

        public void addChildren(INodeComponent leftChild, INodeComponent rightChild){
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }

        public void removeChildren(){
            this.leftChild = null;
            this.rightChild = null;
        }

        public float getValue(){
            if(leftChild == null && rightChild ==null){
                Console.WriteLine("Cannot calculate value without child");
                return 0;
            }
            else{
                float leftChildVal = leftChild.getValue();
                float rightChildVal = rightChild.getValue();

                switch (arithmeticOperation){
                    case "+":
                        return leftChildVal + rightChildVal;
                        break;
                    case "-":
                        return leftChildVal - rightChildVal;
                        break;
                    case "*":
                        return leftChildVal * rightChildVal;
                        break;
                    case "/":
                        return leftChildVal / rightChildVal;
                        break;
                    default:
                        Console.WriteLine("Error");
                        return 0;
                        break;
                }
            }
        }
    }

}