using Microsoft.Xna.Framework;
using Quaver.API.Enums;
using Quaver.Shared.Helpers;

namespace Quaver.Shared.Modifiers.Mods
{
    public class ModLenientLN : IGameplayModifier
    {
        public string Name { get; set; } = "Lenient Long Notes";

        public ModIdentifier ModIdentifier { get; set; } = ModIdentifier.LenientLN;

        public ModType Type { get; set; } = ModType.DifficultyDecrease;

        public string Description { get; set; } = "Long Notes don't have to be released on time.";

        public bool Ranked() => false;

        public bool AllowedInMultiplayer { get; set; } = true;

        public bool OnlyMultiplayerHostCanCanChange { get; set; } = false;

        public bool ChangesMapObjects { get; set; } = false;

        public ModIdentifier[] IncompatibleMods { get; set; } = { ModIdentifier.NoLongNotes };

        public Color ModColor { get; } = ColorHelper.HexToColor("#F2994A");

        public void InitializeMod() { }
    }
}