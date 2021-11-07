using Terraria.ID;
using Terraria.ModLoader;

namespace UnlovedSonsGunMod.Items
{
	public class UnlovedGun : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unloved Gun");
            Tooltip.SetDefault("Don't forget to love your weapon!");
        }

        public override void SetDefaults()
        {
            item.damage = 80;
			item.ranged = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 30000;
			item.rare = ItemRarityID.Green;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/UnlovedGunShot").WithVolume(.5f);
			item.autoReuse = true;
			item.shoot = 12;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.FallenStar;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 50);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
