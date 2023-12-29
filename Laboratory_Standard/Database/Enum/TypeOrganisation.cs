using System.ComponentModel;

namespace Laboratory_Standard.Database.Enum
{
    public enum TypeOrganisation : sbyte
    {
        [Description("Основное место работы")]
        Main = 1,
        [Description("Вторичное место работы")]
        Secondary,
    }
}
