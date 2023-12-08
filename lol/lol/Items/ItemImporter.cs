using lol.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lol.Items
{
    public class ItemImporter
    {
        public ItemImporter()
        {
            var path = @"C:\Users\user\Desktop\Project\lol\Items.Xml";
            Import(path);
        }

        public bool TryGetAttbute(XElement element, out Item item)
        {
            item = null;

            var name = element.Attribute("Name").Value;
            var gold = element.Attribute("Gold").Value;
            var hp = element.Attribute("Hp").Value;
            var ad = element.Attribute("Ad").Value;
            var ap = element.Attribute("Ap").Value;
            var apResistance = element.Attribute("ApResistance").Value;
            var critical = element.Attribute("Critical").Value;
            var mp = element.Attribute("Mp").Value;
            var defense = element.Attribute("Defense").Value;

            if (string.IsNullOrEmpty(name))
                return false;
            else if (!string.IsNullOrEmpty(gold))
                item.Gold = int.Parse(gold);
            else if (!string.IsNullOrEmpty(hp))
                item.HP = double.Parse(hp);
            else if (!string.IsNullOrEmpty(ad))
                item.AD = int.Parse(ad);
            else if (!string.IsNullOrEmpty(ap))
                item.AP = double.Parse(ap);
            else if (!string.IsNullOrEmpty(apResistance))
                item.APResistance = int.Parse(apResistance);
            else if (!string.IsNullOrEmpty(critical))
                item.Critical = double.Parse(critical);
            else if (!string.IsNullOrEmpty(mp))
                item.MP = int.Parse(mp);
            else if (!string.IsNullOrEmpty(defense))
                item.Defense = double.Parse(defense);

            item.Name = name;

            return true;
        }

        public void Import(string path)
        {
            var doc = new XDocument(path);
            var root = doc.Root;
            var items = new List<Item>();

            var elements = root.Elements("Items");

            foreach (var element in elements)
            {
                if (TryGetAttbute(element, out Item itemObject))
                    items.Add(itemObject);
            }
        }
    }
}
