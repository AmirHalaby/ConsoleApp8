using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Vml;
using System.Xml;

namespace ConsoleApp8
{
    public class DictionaryImplementation<k, v> : IEnumerable<KeyValuePair<k, v>>
    {
        LinkedList<KeyValuePair<k, v>> Values;
        public DictionaryImplementation()
        {
            this.Values = new LinkedList<KeyValuePair<k, v>>();
        }

        public void Set(k key, v value)
        {
            if(this.Values == null)
            {
                this.Values = new LinkedList<KeyValuePair<k, v>>();
            }
            var keyExistAlready = this.Values.Any(p => p.Key.Equals(key));
            if (keyExistAlready)
            {
                throw new InvalidOperationException("Key already exists. you cannot add 2 elements with the same key");
            }
            this.Values.AddLast(new KeyValuePair<k, v>(key, value));
        }

        public v? Get(k key)
        {
            if (this.Values == null)
                return default(v);
            var collection = this.Values;
            return collection.First(p => p.Key.Equals(key)).Value;
        }

        public void SetAll(v value)
        {
            var collection = new LinkedList<KeyValuePair<k, v>>();
            foreach (var val in Values)
                collection.AddLast(new KeyValuePair<k, v>(val.Key, value));
            
            this.Values.Clear();

            foreach (var col in collection)
                Set(col.Key, value);
        }

        public IEnumerator<KeyValuePair<k, v>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
