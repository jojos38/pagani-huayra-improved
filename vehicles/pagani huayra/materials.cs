singleton Material(alluminio_part)
{
    mapTo = "alluminio_part";
    diffuseMap[0] = "aluminum.dds";
    diffuseColor[0] = "1 1 1 0.25";
    specularPower[0] = "64";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(lights_pag_on_intense)
{
    mapTo = "lights_pag_on_intense";
   diffuseMap[1] = "vehicles/pagani huayra/lights_on_intense.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   specularPower[0] = "128";
   pixelSpecular[0] = "1";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucentBlendOp = "None";
   alphaTest = "0";
   alphaRef = "0";

    glow[1] = "1";
    emissive[1] = "1";
   dynamicCubemap = true;
   materialTag0 = "beamng"; materialTag1 = "vehicle";  
};

singleton Material(lights_pag_on)
{
    mapTo = "lights_pag_on";
   diffuseMap[1] = "vehicles/pagani huayra/lights_on.dds";
   diffuseMap[0] = "vehicles/common/null.dds";
   specularMap[0] = "vehicles/common/null.dds";
   specularPower[0] = "128";
   pixelSpecular[0] = "1";
   specularPower[1] = "32";
   pixelSpecular[1] = "1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   castShadows = "1";
   translucentBlendOp = "None";
   alphaTest = "0";
   alphaRef = "0";

    glow[1] = "1";
    emissive[1] = "1";
   dynamicCubemap = true;
   materialTag0 = "beamng"; materialTag1 = "vehicle";  
};

singleton Material(PAG_HUAYRA_DISC)
{
    mapTo = "PAG_HUAYRA_DISC";
    diffuseMap[0] = "metalplaceholder.dds";
    diffuseColor[0] = "1 1 1 0.25";
    specularPower[0] = "64";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_PAINT)
{
    mapTo = "PAG_HUAYRA_PAINT";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    doubleSided = "0";
    translucentZWrite = "1";
    diffuseMap[2] = "gtr_main_c.dds";
    specularMap[2] = "gtr_specocc.dds";
    diffuseMap[1] = "gtr_main_d.dds";
    specularMap[1] = "gtr_specocc.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "Nbody.dds";
    normalMap[0] = "Nbody.dds";
    normalMap[1] = "Nbody.dds";
    normalMap[2] = "Nbody.dds";
  specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "0";
   translucent = "1";
   translucentBlendOp = "None";
   alphaRef = "0";
   dynamicCubemap = "1";
   materialTag1 = "vehicle";
   materialTag0 = "beamng";
   alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
   diffuseColor[2] = "0.992156923 0.992156923 0.992156923 0.561999977";
   specular[2] = "0.70588237 0.70588237 0.70588237 2";
   specularPower[2] = "1";
};

singleton Material("PAG_HUAYRA_PAINT.skin.singleligne")
{
    mapTo = "PAG_HUAYRA_PAINT.skin.singleligne";
	diffuseColor[0] = "1 1 1 0.1";
	diffuseMap[0] = "singleligne.dds";
        specularPower[1] = "32";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};


singleton Material("PAG_HUAYRA_PAINT.skin.redline")
{
    mapTo = "PAG_HUAYRA_PAINT.skin.redline";
	diffuseColor[0] = "1 1 1 0.1";
	diffuseMap[0] = "redline.dds";
        specularPower[1] = "32";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("PAG_HUAYRA_PAINT.skin.smallline")
{
    mapTo = "PAG_HUAYRA_PAINT.skin.smallline";
	diffuseColor[0] = "1 1 1 0.1";
	diffuseMap[0] = "smallline.dds";
        specularPower[1] = "32";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("super.skin.civetta")
{
    mapTo = "super.skin.civetta";
    colorPaletteMap[2] = "vehicles/super/super_skin_civetta_uv1.dds";
    diffuseMap[2] = "vehicles/super/super_c.dds";
    specularMap[2] = "vehicles/super/super_s.dds";
    normalMap[2] = "vehicles/super/super_n.dds";
    diffuseMap[1] = "vehicles/super/super_d.dds";
    specularMap[1] = "vehicles/super/super_s.dds";
    normalMap[1] = "vehicles/super/super_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/super/super_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material("super.skin.scuderiabolide")
{
    mapTo = "super.skin.scuderiabolide";
    overlayMap[2] = "vehicles/super/super_skin_scuderiabolide.dds";
    diffuseMap[2] = "vehicles/super/super_c.dds";
    specularMap[2] = "vehicles/super/super_s.dds";
    normalMap[2] = "vehicles/super/super_n.dds";
    diffuseMap[1] = "vehicles/super/super_d.dds";
    specularMap[1] = "vehicles/super/super_s.dds";
    normalMap[1] = "vehicles/super/super_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/super/super_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_LIGHTS)
{
   mapTo = "PAG_HUAYRA_LIGHTS";
    diffuseMap[0] = "lights.dds";
    normalMap[0] = "lights_nm.dds";
    specularMap[0] = "lights_s.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(GENERIC_LICPLATE_EURO)
{
   mapTo = "GENERIC_LICPLATE_EURO";
    diffuseMap[0] = "plate.dds";
    normalMap[0] = "plate_nm.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_MISC)
{
   mapTo = "PAG_HUAYRA_MISC";
    diffuseMap[0] = "misc.dds";
    diffuseMap[1] = "misc.dds";
    normalMap[0] = "misc_nm.dds";
    normalMap[1] = "misc_nm.dds";
    specularMap[0] = "misc_s.dds";
    specularMap[1] = "misc_s.dds";
   doubleSided = "1";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; 
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_WINDOWS_2)
{

   mapTo = "PAG_HUAYRA_WINDOWS_2";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "glass_d.dds";
    opacityMap[0] = "glass_d.dds";
    diffuseMap[1] = "glass_da.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_COCKPIT_2)
{
   mapTo = "PAG_HUAYRA_COCKPIT_2";
    diffuseMap[0] = "sym_2.dds";
    specularMap[0] = "sym_2_s.dds";
    normalMap[0] = "sym_2_n.dds";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
};

singleton Material(PAG_HUAYRA_SW)
{
    mapTo = "PAG_HUAYRA_SW";
    diffuseMap[0] = "cockpit_f.dds";
    specularMap[0] = "cockpit_f_s.dds";
    normalMap[0] = "cockpit_f_n.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_SW_GLOW)
{
    mapTo = "PAG_HUAYRA_SW_GLOW";
    diffuseMap[0] = "cockpit_f_g.dds";
    specularMap[0] = "cockpit_f_s.dds";
    normalMap[0] = "cockpit_f_n.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    emissive[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(GENERIC_LCD)
{
    mapTo = "GENERIC_LCD";
    diffuseMap[0] = "lcd.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    emissive[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_display)
{
    mapTo = "pag_display";
    diffuseMap[0] = "screen.dds";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    emissive[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_CARBON_SILVER)
{
   mapTo = "PAG_HUAYRA_CARBON_SILVER";
    diffuseMap[0] = "carbon_silver.dds";
    normalMap[0] = "carbon_n.dds";
    diffuseColor[0] = "1 1 1 0.1";
    dynamicCubemap = true;
    doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_COCKPIT)
{
   mapTo = "PAG_HUAYRA_COCKPIT";
    diffuseMap[0] = "gauges.dds";
    diffuseMap[1] = "gauges.dds";
    specularMap[0] = "gauges_s.dds";
    specularMap[1] = "gauges_s.dds";
    //normalMap[0] = "gauges_nm.dds";
    //normalMap[1] = "gauges_nm.dds";
    diffuseColor[0] = "1 1 1 0.1";
    dynamicCubemap = true;
    doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_COCKPIT_FRESNEL)
{
   mapTo = "PAG_HUAYRA_COCKPIT_FRESNEL";
    diffuseMap[0] = "cockpit_f.dds";
    specularMap[0] = "cockpit_f_s.dds";
    normalMap[0] = "cockpit_f_n.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = false;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_LEATHER)
{
   mapTo = "PAG_HUAYRA_LEATHER";
    diffuseMap[0] = "leather_b.dds";
    normalMap[0] = "leather_b_n.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = false;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_LEATHER_STITCHES)
{
   mapTo = "PAG_HUAYRA_LEATHER_STITCHES";
    diffuseMap[0] = "stitch.dds";
    normalMap[0] = "stitch_n.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = false;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_INTERIOR)
{
   mapTo = "PAG_HUAYRA_INTERIOR";
    diffuseMap[0] = "int.dds";
    specularMap[0] = "int_s.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = false;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_INTERIOR_GLOW)
{
   mapTo = "PAG_HUAYRA_INTERIOR_GLOW";
    diffuseMap[0] = "int_glow.dds";
    specularMap[0] = "int_s.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = false;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_MISC_2)
{
   mapTo = "PAG_HUAYRA_MISC_2";
    diffuseMap[0] = "misc_2.dds";
    diffuseMap[1] = "misc_2.dds";
    normalMap[0] = "misc_2_nm.dds";
    normalMap[1] = "misc_2_nm.dds";
    specularMap[0] = "misc_2_s.dds";
    specularMap[1] = "misc_2_s.dds";
    doubleSided = "1";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; 
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_BADGES_SKIN)
{
   mapTo = "PAG_HUAYRA_BADGES_SKIN";
    diffuseMap[0] = "symbols.dds";
    diffuseMap[1] = "symbols.dds";
    diffuseMap[2] = "symbols.dds";
    normalMap[0] = "symbols_nm.dds";
    normalMap[1] = "symbols_nm.dds";
    normalMap[2] = "symbols_nm.dds";
    specularMap[0] = "symbols_s.dds";
    specularMap[1] = "symbols_s.dds";
    specularMap[2] = "symbols_s.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   specular[0] = "0 0 0 1";
   specularPower[0] = "50";
   translucent = "0";
   diffuseColor[1] = "1 1 1 0.423";
   diffuseColor[2] = "1 1 1 0.664";
   specularPower[0] = "128";
   pixelSpecular[0] = "1";
   diffuseColor[0] = "1 1 1 1";
   useAnisotropic[0] = "1";
   castShadows = "0";
   translucent = "1";
   alphaTest = "0";
   alphaRef = "0";
   dynamicCubemap = true;
   materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_BADGES)
{
   mapTo = "PAG_HUAYRA_BADGES";
    diffuseMap[0] = "symbols.dds";
    opacityMap[0] = "symbols.dds";
    diffuseMap[1] = "symbols.dds";
    specularMap[0] = "symbols_s.dds";
    normalMap[0] = "symbols_nm.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(PAG_HUAYRA_PAINT_2)
{
   mapTo = "PAG_HUAYRA_PAINT_2";
    diffuseMap[0] = "carbon_blackbody2.dds";
    diffuseMap[1] = "carbon_blackbody2.dds";
    normalMap[0] = "body2_n.dds";
    normalMap[1] = "body2_n.dds";
    specularMap[0] = "body2_s.dds";
    specularMap[1] = "body2_s.dds";
    doubleSided = "1";
    specularPower[0] = "16";
    pixelSpecular[0] = "1";
    specularPower[1] = "16";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; 
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(COMMON_PAGANI_CARBON)
{
   mapTo = "COMMON_PAGANI_CARBON";
    diffuseMap[0] = "carbon_black.dds";
    normalMap[0] = "carbon_n.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_glass_black)
{
    mapTo = "pag_glass_black";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "glass_black.dds";
    opacityMap[0] = "glass_COLOR.dds";
    diffuseMap[1] = "glass_black.dds";
    specularMap[0] = "vehicles/common/null.dds";
    //normalMap[0] = "Nbody.dds";
    //normalMap[1] = "Nbody.dds";
    //normalMap[0] = "vehicles/common/null_n.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_glass)
{
    mapTo = "pag_glass";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "glass_COLOR.dds";
    opacityMap[0] = "glass_COLOR.dds";
    diffuseMap[1] = "glass_COLOR.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_glass_int)
{
    mapTo = "pag_glass_int";
    diffuseMap[0] = "glass_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    doubleSided = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_glass_dmg)
{
    mapTo = "pag_glass_dmg";
    diffuseMap[0] = "glass_dmg_d.dds";
    opacityMap[0] = "glass_dmg_d.dds";
    diffuseMap[1] = "glass_dmg_d.dds";
    specularPower[0] = "128";
    specularPower[1] = "128";
    diffuseColor[0] = "1 1 1 1.5";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_windshield_dmg)
{
    mapTo = "pag_windshield_dmg";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/common/windshield_dmg_n.dds";
    specularPower[0] = "32";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_gauges)
{
    mapTo = "pag_gauges";
    diffuseMap[0] = "gauges.dds";
    diffuseMap[1] = "gauges.dds";
    diffuseMap[2] = "gauges.dds";
    specularMap[0] = "gauges_s.dds";
    specularMap[1] = "gauges_s.dds";
    specularMap[2] = "gauges_s.dds";
    normalMap[0] = "gauges_nm.dds";
    normalMap[1] = "gauges_nm.dds";
    normalMap[2] = "gauges_nm.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 1";
};

singleton Material(pag_gauges_on)
{
    mapTo = "pag_gauges_on";
    diffuseMap[1] = "gauges_on.dds";
    specularMap[1] = "gauges_s.dds";
    normalMap[1] = "gauges_n.dds";
    diffuseMap[0] = "gauges.dds";
    specularMap[0] = "gauges_s.dds";
    normalMap[0] = "gauges_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    emissive[1] = "1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 0.5 0 1";
};

singleton Material(pag_lights)
{
    mapTo = "pag_lights";
    diffuseMap[1] = "lights.dds";
    specularMap[1] = "lights_s.dds";
    normalMap[1] = "lights_nm.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "lights_nm.dds";
    //diffuseMap[2] = "lights.dds";
    //normalMap[2] = "lights_nm.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    //diffuseColor[2] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_lights_on)
{
    mapTo = "pag_lights_on";
    diffuseMap[2] = "lights_on.dds";
    specularMap[2] = "lights_s.dds";
    normalMap[2] = "lights_nm.dds";
    diffuseMap[1] = "lights.dds";
    specularMap[1] = "lights_s.dds";
    normalMap[1] = "lights_nm.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "lights_nm.dds";
    //diffuseMap[3] = "lights.dds";
    //normalMap[3] = "lights_nm.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.12";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    //diffuseColor[3] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    glow[2] = "1";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_lights_on_intense)
{
    mapTo = "pag_lights_on_intense";
    diffuseMap[2] = "lights_on.dds";
    specularMap[2] = "lights_s.dds";
    normalMap[2] = "lights_nm.dds";
    diffuseMap[1] = "lights.dds";
    specularMap[1] = "lights_s.dds";
    normalMap[1] = "lights_nm.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "lights_nm.dds";
    //diffuseMap[3] = "lights.dds";
    //normalMap[3] = "lights_nm.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.20";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    //diffuseColor[3] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    glow[2] = "1";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_lights_dmg)
{
    mapTo = "pag_lights_dmg";
    diffuseMap[1] = "lights.dds";
    specularMap[1] = "lights_s.dds";
    normalMap[1] = "lights_nm.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "lights_nm.dds";
    //diffuseMap[2] = "lights.dds";
    //normalMap[2] = "lights_nm.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    //diffuseColor[2] = "1.5 1.5 1.5 1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(pag_signal_L)
{
    mapTo = "pag_signal_L";
};

singleton Material(pag_signal_R)
{
    mapTo = "pag_signal_R";
};

singleton Material(pag_taillight_R)
{
    mapTo = "pag_taillight_R";
};

singleton Material(pag_taillight_L)
{
    mapTo = "pag_taillight_L";
};

singleton Material(pag_brakelight)
{
    mapTo = "pag_brakelight";
};

singleton Material(pag_parkinglight)
{
    mapTo = "pag_parkinglight";
};

singleton Material(pag_headlight)
{
    mapTo = "pag_headlight";
};

singleton Material(pag_reverselight)
{
    mapTo = "pag_reverselight";
};

singleton Material(GENERIC_MIRROR_SKIN)
{
    mapTo = "GENERIC_MIRROR_SKIN";
	specularPower[0] = "128";
	useAnisotropic[0] = "1";
	dynamicCubemap = true;
	cubemap = "global_cubemap_metalblurred";
	castShadows = "1";
    translucent = "0";
    alphaTest = "0";
    alphaRef = "0";
};

