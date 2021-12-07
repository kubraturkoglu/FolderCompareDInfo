using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1  
{
    class FileCompare :IEqualityComparer<System.IO.FileInfo>
    {
        public FileCompare() { }

        public bool Equals(System.IO.FileInfo f1, System.IO.FileInfo f2)
        {
            return (f1.Name == f2.Name );
        }

        
        public int GetHashCode(System.IO.FileInfo fi)
        {
            //   string s = String.Format("{0}", fi.Name);
            //  return s.GetHashCode();
            return (fi.Name.GetHashCode() * 251);
        }
    }
}
// Return a hash that reflects the comparison criteria. According to the
        // rules for IEqualityComparer<T>, if Equals is true, then the hash codes must  
        // also be equal. Because equality as defined here is a simple value equality, not  
        // reference identity, it is possible that two or more objects will produce the same  
        // hash code.  
