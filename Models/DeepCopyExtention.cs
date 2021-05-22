using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class DeepCopyExtention
    {
        public static T CopyObject<T>(this object objSource)

        {

            using (MemoryStream stream = new MemoryStream())

            {

                if (objSource.GetType().IsSerializable)

                {

                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(stream, objSource);

                    stream.Position = 0;

                    return (T)formatter.Deserialize(stream);

                }

                return default(T);

            }

        }
    }
}
