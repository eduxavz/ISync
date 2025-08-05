using System;

namespace ISync.Core.Enums
{
    [AttributeUsage(AttributeTargets.Field)]
    public class GrupoAttribute : Attribute
    {
        public string Grupo { get; private set; }

        public GrupoAttribute(string valor)
        {
            Grupo = valor;
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class ItemDropAttribute : Attribute
    {
        public string ItemDrop { get; private set; }

        public ItemDropAttribute(string valor)
        {
            ItemDrop = valor;
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class ValorPadraoAttribute : Attribute
    {
        public string ValorPadrao { get; private set; }

        public ValorPadraoAttribute(string valor)
        {
            ValorPadrao = valor;
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class VMinPadraoAttribute : Attribute
    {
        public int VMinPadrao { get; private set; }

        public VMinPadraoAttribute(int valor)
        {
            VMinPadrao = valor;
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class VMaxPadraoAttribute : Attribute
    {
        public int VMaxPadrao { get; private set; }

        public VMaxPadraoAttribute(int valor)
        {
            VMaxPadrao = valor;
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class TpControleAttribute : Attribute
    {
        public int TpControle { get; private set; }

        public TpControleAttribute(int valor)
        {
            TpControle = valor;
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class TpTxtAttribute : Attribute
    {
        public string TpTxt { get; private set; }

        public TpTxtAttribute(string valor)
        {
            TpTxt = valor;
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class OrdemAttribute : Attribute
    {
        public int Ordem { get; private set; }

        public OrdemAttribute(int valor)
        {
            Ordem = valor;
        }
    }
}
