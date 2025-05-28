using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaklyMiniProject2
{
    /* THis class is unnecessary. It would be easier to just use List<Product>. I created it just to practice 
     * extending the IEnumerable-interface (hence one can call Linq-methods and foreach-loop on the ProductList-class*/

    public class ProductList: IEnumerable<Product>
    {
        public ProductList() {
            MaxElements = 2;  //Start with some number of elements that the array can hold.
            _elements = new Product[MaxElements];
        }

        public int MaxElements { get; set; }
        public Product[] _elements;
        public int LastIndex { get; set; } = 0; // the index of the current last element in the array.

        public Product this[int idx] => _elements[idx]; //so that one can use indexing on the ProductList.

        public void Add(Product product)
        {
           
            if (_elements.Length >= MaxElements)
            {
              
                MaxElements *=2;
                Array.Resize(ref _elements, MaxElements);
            }       
            
            _elements[LastIndex] = product; //insert new product after.
            LastIndex++;
        }


        /*Since _elements is a preallocated array, some elements may be null. _elements[0..LastIndex] returns sub-array
         * with non-null elements. We cast it to (IEnumerable<Product>) and then call the GetEnumerator()-methdo*/
        public IEnumerator<Product> GetEnumerator() => ((IEnumerable<Product>)_elements[0..LastIndex]).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();




    }
}
