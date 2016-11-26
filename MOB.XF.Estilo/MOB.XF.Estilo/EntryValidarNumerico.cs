using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MOB.XF.Estilo
{
    public class EntryValidarNumerico : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int parsed;

            bool validar = int.TryParse(sender.Text, out parsed);
            if (!validar)
                sender.TextColor = Color.Red;
            else
                sender.TextColor = Color.Blue;
        }
    }
}
