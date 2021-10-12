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
    diffuseColor[0] = "1 1 1 0.25";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   colorMap[0] = "/vehicles/pagani huayra/metalplaceholder.dds";
   roughnessFactor[0] = "0.519615531";
};

singleton Material(PAG_HUAYRA_PAINT)
{
    mapTo = "PAG_HUAYRA_PAINT";
    castShadows = "1";
    translucent = "1";
    doubleSided = "0";
    translucentZWrite = "1";
    normalMap[0] = "/vehicles/pagani huayra/Nbody.dds";
    normalMap[1] = "/vehicles/pagani huayra/Nbody.dds";
    normalMap[2] = "Nbody.dds";
    pixelSpecular[0] = "1";
    pixelSpecular[1] = "1";
    pixelSpecular[1] = "1";
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
   specular[2] = "0.70588237 0.70588237 0.70588237 2";
   version = "1.5";
   activeLayers = "2";
   instanceDiffuse[1] = "1";
   baseColorMap[0] = "/vehicles/pagani huayra/pag_b.dds";
   baseColorMap[2] = "gtr_main_c.dds";
   baseColorFactor[2] = "0.992156923 0.992156923 0.992156923 0.561999977";
   roughnessMap[0] = "/vehicles/pagani huayra/pag_r.dds";
   clearCoatMap[1] = "/vehicles/pagani huayra/pag_cc.dds";
   clearCoatFactor[1] = "1";
   opacityMap[1] = "/vehicles/pagani huayra/pag_cc.dds";
   colorPaletteMap[1] = "/vehicles/pagani huayra/pag_p.dds";
   roughnessFactor[1] = "0.445299804";
   metallicFactor[1] = "1";
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
    normalMap[0] = "/vehicles/pagani huayra/misc_nm.dds";
    normalMap[1] = "/vehicles/pagani huayra/misc_nm.dds";
   doubleSided = "1";
    pixelSpecular[0] = "1";
    pixelSpecular[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; 
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   version = "1.5";
   roughnessFactor[0] = "0.722649872";
   roughnessFactor[1] = "0.722649872";
   baseColorMap[0] = "/vehicles/pagani huayra/misc.dds";
   baseColorMap[1] = "/vehicles/pagani huayra/misc.dds";
   metallicFactor[0] = "1";
};

singleton Material(PAG_HUAYRA_WINDOWS_2)
{

   mapTo = "PAG_HUAYRA_WINDOWS_2";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    opacityMap[0] = "/vehicles/pagani huayra/glass_d.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    pixelSpecular[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   version = "1.5";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/pagani huayra/glass_d.dds";
   baseColorMap[1] = "/vehicles/pagani huayra/glass_da.dds";
   baseColorFactor[0] = "3.92156911 0 0 1";
   baseColorFactor[1] = "0.5 0.5 0.5 0.75";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   detailScale[0] = "1 1";
   translucentBlendOp = "PreMulAlpha";
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
    specularMap[0] = "/vehicles/pagani huayra/cockpit_f_s.dds";
    normalMap[0] = "/vehicles/pagani huayra/cockpit_f_n.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   instanceDiffuse[2] = "1";
   colorMap[0] = "/vehicles/pagani huayra/cockpit_f.dds";
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
    specularMap[0] = "/vehicles/pagani huayra/gauges_s.dds";
    specularMap[1] = "gauges_s.dds";
    //normalMap[0] = "gauges_nm.dds";
    //normalMap[1] = "gauges_nm.dds";
    diffuseColor[0] = "1 1 1 0.1";
    dynamicCubemap = true;
    doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   instanceDiffuse[2] = "1";
   colorMap[0] = "/vehicles/pagani huayra/gauges.dds";
   colorMap[1] = "/vehicles/pagani huayra/gauges.dds";
};

singleton Material(PAG_HUAYRA_COCKPIT_FRESNEL)
{
   mapTo = "PAG_HUAYRA_COCKPIT_FRESNEL";
    specularMap[0] = "/vehicles/pagani huayra/cockpit_f_s.dds";
    normalMap[0] = "/vehicles/pagani huayra/cockpit_f_n.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = false;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   instanceDiffuse[2] = "1";
   colorMap[0] = "/vehicles/pagani huayra/cockpit_f.dds";
};

singleton Material(PAG_HUAYRA_LEATHER)
{
   mapTo = "PAG_HUAYRA_LEATHER";
    normalMap[0] = "/vehicles/pagani huayra/leather_b_n.dds";
	dynamicCubemap = false;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   version = "1.5";
   instanceDiffuse[2] = "1";
   baseColorMap[0] = "/vehicles/pagani huayra/leather_b.dds";
   baseColorFactor[0] = "0.63529402 0.474510014 0.227450997 1";
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
    normalMap[0] = "/vehicles/pagani huayra/misc_2_nm.dds";
    normalMap[1] = "/vehicles/pagani huayra/misc_2_nm.dds";
    doubleSided = "1";
    pixelSpecular[0] = "1";
    pixelSpecular[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; 
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   version = "1";
   roughnessFactor[0] = "0.722649872";
   roughnessFactor[1] = "0.722649872";
   colorMap[0] = "/vehicles/pagani huayra/misc_2.dds";
   colorMap[1] = "/vehicles/pagani huayra/misc_2.dds";
   specularMap[0] = "/vehicles/pagani huayra/misc_2_s.dds";
   specularMap[1] = "misc_2_s.dds";
   useAnisotropic[0] = "1";
   useAnisotropic[1] = "1";
   useAnisotropic[2] = "1";
};

singleton Material(PAG_HUAYRA_BADGES_SKIN)
{
   mapTo = "PAG_HUAYRA_BADGES_SKIN";
    normalMap[0] = "/vehicles/pagani huayra/symbols_nm.dds";
    normalMap[1] = "/vehicles/pagani huayra/symbols_nm.dds";
    normalMap[2] = "symbols_nm.dds";
   specular[0] = "0 0 0 1";
   translucent = "1";
   pixelSpecular[0] = "1";
   castShadows = "0";
   translucent = "1";
   alphaTest = "0";
   alphaRef = "0";
   dynamicCubemap = true;
   materialTag0 = "beamng"; materialTag1 = "vehicle";
   version = "1.5";
   roughnessFactor[0] = "0.234999999";
   baseColorMap[0] = "/vehicles/pagani huayra/symbols.dds";
   baseColorMap[1] = "/vehicles/pagani huayra/symbols.dds";
   baseColorMap[2] = "symbols.dds";
   baseColorFactor[1] = "1 1 1 0.423000008";
   baseColorFactor[2] = "1 1 1 0.663999975";
   metallicFactor[0] = "0.629999995";
   detailScale[0] = "1 1";
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
    normalMap[0] = "/vehicles/pagani huayra/body2_n.dds";
    normalMap[1] = "/vehicles/pagani huayra/body2_n.dds";
    doubleSided = "1";
    pixelSpecular[0] = "1";
    pixelSpecular[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true; 
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   version = "1.5";
   activeLayers = "2";
   baseColorMap[0] = "/vehicles/pagani huayra/carbon_blackbody2.dds";
   baseColorMap[1] = "/vehicles/pagani huayra/carbon_blackbody2.dds";
   baseColorFactor[1] = "0.392156988 0.392156988 0.392156988 1";
   roughnessMap[0] = "/vehicles/pagani huayra/Nbody.dds";
   clearCoatMap[1] = "/vehicles/pagani huayra/pag_cc.dds";
   clearCoatFactor[1] = "1";
   opacityMap[1] = "/vehicles/pagani huayra/pag_cc.dds";
   colorPaletteMap[1] = "/vehicles/pagani huayra/pag_p.dds";
   detailScale[1] = "1 1";
   detailNormalMap[1] = "/vehicles/pagani huayra/body2_n.dds";
};

singleton Material(COMMON_PAGANI_CARBON)
{
   mapTo = "COMMON_PAGANI_CARBON";
    normalMap[0] = "/vehicles/pagani huayra/carbon_n.dds";
	diffuseColor[0] = "1 1 1 0.1";
	dynamicCubemap = true;
	doubleSided = "1";
    beamngDiffuseColorSlot = 2; //cubemap = "BNG_Sky_02_cubemap";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
   instanceDiffuse[2] = "1";
   colorMap[0] = "/vehicles/pagani huayra/carbon_black.dds";
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
    //normalMap[1] = "gauges_n.dds";
    diffuseMap[0] = "gauges.dds";
    specularMap[0] = "gauges_s.dds";
    //normalMap[0] = "gauges_n.dds";
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
   activeLayers = "3";
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


singleton Material(pag_glass)
{
   mapTo = "pag_glass";
   version = "1.5";
   diffuseMapUseUV[0] = "1";
   normalMap[0] = "vehicles/common/null_n.dds";
   roughnessFactor[0] = "0.445299804";
   baseColorMap[0] = "/vehicles/pagani huayra/glass_COLOR.dds";
   baseColorMap[1] = "/vehicles/pagani huayra/glass_COLOR.dds";
   baseColorFactor[0] = "0.588235021 1 1 1";
   baseColorFactor[1] = "0.5 0.5 0.5 0.75";
   clearCoatFactor[0] = "1";
   clearCoatRoughnessFactor[0] = "0";
   opacityMap[0] = "/vehicles/pagani huayra/glass_COLOR.dds";
   reflectivityMap[0] = "vehicles/common/glass_base.dds";
   pixelSpecular[0] = "1";
   diffuseMapUV[0] = "1";
   castShadows = "0";
   translucent = "1";
   translucentBlendOp = "PreMulAlpha";
   alphaRef = "0";
   dynamicCubemap = "1";
   persistentId = "6ad2380a-c84c-4dba-bb1e-24310d5e21bf";
   materialTag0 = "beamng";
   materialTag1 = "vehicle";
};

singleton Material(pag_glass_black)
{
   mapTo = "pag_glass_black";
   version = "1.5";
   activeLayers = "2";
   detailMapUseUV[0] = "1";
   roughnessFactor[0] = "0";
   baseColorMap[0] = "/vehicles/pagani huayra/glass_black.dds";
   baseColorMap[1] = "/vehicles/pagani huayra/glass_black.dds";
   baseColorFactor[0] = "1 1.50196099 1.50196099 1";
   baseColorFactor[1] = "1 1 1 8.05882359";
   opacityFactor[1] = "0.949999988";
   metallicFactor[0] = "1";
   clearCoatFactor[1] = "1";
   clearCoatRoughnessFactor[0] = "0";
   clearCoatRoughnessFactor[1] = "0";
   opacityMap[0] = "/vehicles/pagani huayra/glass_COLOR.dds";
   reflectivityMap[0] = "vehicles/common/glass_base.dds";
   pixelSpecular[0] = "1";
   detailMapUV[0] = "1";
   translucent = "1";
   translucentBlendOp = "PreMulAlpha";
   alphaRef = "0";
   dynamicCubemap = "1";
   persistentId = "104714b2-708e-4ecc-b892-fff7c7841169";
   materialTag0 = "beamng";
   materialTag1 = "vehicle";
};
