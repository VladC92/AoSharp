﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOSharp.Common.GameData
{
    public enum NanoLine
    {
        NOSTACKING = 0,
        DamageShields = 1,
        ReflectShield = 2,
        ArmorBuff = 3,
        DamageBuffs_LineA = 4,
        Challenger = 5,
        DOT_LineA = 6,
        DOT_LineB = 7,
        DOTNanotechnicianStrainA = 8,
        DOTAgentStrainA = 9,
        DOTNanotechnicianStrainB = 10,
        HaloNanoDebuff = 11,
        HealOverTime = 12,
        AAODebuffs = 13,
        NanoOverTime_LineA = 14,
        XPBonus = 15,
        General1HandBluntBuff = 16,
        General1HandBluntDebuff = 17,
        GeneralAimedShotBuff = 18,
        GeneralAimedShotDebuff = 19,
        GeneralAirTransportBuff = 20,
        General1HEdgedBuff = 21,
        General1HEdgedDebuff = 22,
        General2HBluntBuff = 23,
        General2HBluntDebuff = 24,
        General2HEdgedBuff = 25,
        General2HEdgedDebuff = 26,
        GeneralAssaultRifleBuff = 27,
        GeneralAssaultRifleDebuff = 28,
        GeneralAgilityBuff = 29,
        GeneralIntelligenceBuff = 30,
        GeneralPsychicBuff = 31,
        GeneralSenseBuff = 32,
        GeneralStaminaBuff = 33,
        GeneralStrengthBuff = 34,
        GeneralBioMetBuff = 35,
        GeneralBioMetDebuff = 36,
        GeneralBowBuff = 37,
        GeneralBowDebuff = 38,
        GeneralBowSpecialBuff = 39,
        GeneralBowSpecialDebuff = 40,
        GeneralBrawlBuff = 41,
        GeneralBrawlDebuff = 42,
        GeneralBreakEntryBuff = 43,
        GeneralBurstBuff = 44,
        GeneralBurstDebuff = 45,
        GeneralChemicalACBuff = 46,
        GeneralChemistryBuff = 47,
        GeneralClimbBuff = 48,
        GeneralColdACBuff = 49,
        GeneralComputerLiteracyBuff = 50,
        GeneralConcealmentBuff = 51,
        GeneralDimachDebuff = 52,
        GeneralAgilityDebuff = 53,
        GeneralIntelligenceDebuff = 54,
        GeneralPsychicDebuff = 55,
        GeneralSenseDebuff = 56,
        GeneralStaminaDebuff = 57,
        GeneralStrengthDebuff = 58,
        GeneralDisarmTrapsBuff = 59,
        GeneralElectricalEngineeringBuff = 60,
        GeneralEnergyMeleeBuff = 61,
        GeneralEnergyMeleeDebuff = 62,
        GeneralEnergyACBuff = 63,
        GeneralLREnergyWeaponBuff = 64,
        GeneralLREnergyWeaponDebuff = 65,
        GeneralFastAttackBuff = 66,
        GeneralFastAttackDebuff = 67,
        GeneralFieldQuantumPhysicsBuff = 68,
        GeneralFireACBuff = 69,
        GeneralFirstAidBuff = 70,
        GeneralFlingShotBuff = 71,
        GeneralFlingShotDebuff = 72,
        GeneralFullAutoBuff = 73,
        GeneralFullAutoDebuff = 74,
        GeneralThrownGrapplingBuff = 75,
        GeneralThrownGrapplingDebuff = 76,
        GeneralGrenadeBuff = 77,
        GeneralGrenadeDebuff = 78,
        GeneralGroundTransportBuff = 79,
        GeneralMaxHealthBuff = 80,
        GeneralKnifeBuff = 81,
        GeneralKnifeDebuff = 82,
        GeneralSMGBuff = 83,
        GeneralSMGDebuff = 84,
        GeneralMartialArtsBuff = 85,
        GeneralMartialArtsDebuff = 86,
        GeneralMatCreaBuff = 87,
        GeneralMatCreaDebuff = 88,
        GeneralMatLocBuff = 89,
        GeneralMatLocDebuff = 90,
        GeneralMatMetBuff = 91,
        GeneralMatMetDebuff = 92,
        GeneralMechanicalEngineeringBuff = 93,
        GeneralMeleeACBuff = 94,
        GeneralNanoProgrammingBuff = 95,
        GeneralNanoACBuff = 96,
        GeneralNPRegeneration = 97,
        GeneralDeflectBuff = 98,
        GeneralDeflectDebuff = 99,
        GeneralPharmaceuticalBuff = 100,
        GeneralPiercingBuff = 101,
        GeneralPiercingDebuff = 102,
        GeneralPistolBuff = 103,
        GeneralPistoDebuff = 104,
        GeneralPoisonACBuff = 105,
        GeneralProjectileACBuff = 106,
        GeneralPsychologyBuff = 107,
        GeneralPsyModBuff = 108,
        GeneralPsyModDebuff = 109,
        GeneralRadiationACBuff = 110,
        GeneralHPRegeneration = 111,
        GeneralRifleBuff = 112,
        GeneralRifleDebuff = 113,
        GeneralRiposteBuff = 114,
        GeneralRiposteDebuff = 115,
        GeneralSenseImpBuff = 116,
        GeneralSenseImpDebuff = 117,
        GeneralShotgunBuff = 118,
        GeneralShotgunDebuff = 119,
        GeneralSneakAttackBuff = 120,
        GeneralSneakAttackDebuff = 121,
        GeneralNanoACDebuff = 122,
        GeneralPoisonACDebuff = 123,
        GeneralSwimBuff = 124,
        GeneralTreatmentBuff = 125,
        GeneralTutoringBuff = 126,
        GeneralChemicalACDebuff = 127,
        GeneralColdACDebuff = 128,
        GeneralEnergyACDebuff = 129,
        GeneralFireACDebuff = 130,
        GeneralMeleeACDebuff = 131,
        GeneralProjectileACDebuff = 132,
        GeneralRadiationACDebuff = 133,
        GeneralWeaponSmithingBuff = 134,
        TraderSkillTransferTargetDebuff_Deprive = 135,
        TraderSkillTransferTargetDebuff_Ransack = 136,
        TraderSkillTransferCasterBuff_Deprive = 137,
        TraderSkillTransferCasterBuff_Ransack = 138,
        TraderACTransferTargetDebuff_Siphon = 139,
        TraderACTransferTargetDebuff_Draw = 140,
        TraderACTransferCasterBuff_Siphon = 141,
        TraderACTransferCasterBuff_Draw = 142,
        TraderACTransferTargetBuff_Redeem = 143,
        MajorEvasionBuffs = 144,
        Snare = 145,
        Root = 146,
        Mezz = 147,
        NPCostBuff = 148,
        GeneralRunspeedBuffs = 149,
        RunspeedBuffs = 150,
        HPBuff = 151,
        InitiativeBuffs = 152,
        _2HEdgedBuff = 153,
        BrawlBuff = 154,
        RiposteBuff = 155,
        StrengthBuff = 156,
        MatMetBuff = 157,
        MatMetDebuff = 158,
        MatCreaBuff = 159,
        MatCreaDebuff = 160,
        MatLocBuff = 161,
        MatLocDebuff = 162,
        BioMetBuff = 163,
        BioMetDebuff = 164,
        SenseImpBuff = 165,
        SenseImpDebuff = 166,
        PsyModBuff = 167,
        PsyModDebuff = 168,
        PsychicDebuff = 169,
        IntelligenceDebuff = 170,
        Break_EntryBuffs = 171,
        ElectricalEngineeringBuff = 172,
        FieldQuantumPhysicsBuff = 173,
        MechanicalEngineeringBuff = 174,
        PharmaceuticalsBuff = 175,
        WeaponSmithingBuff = 176,
        ComputerLiteracyBuff = 177,
        NPBuff = 178,
        _1HBluntBuff = 179,
        MeleeWeaponBuffLine = 180,
        NFRangeBuff = 181,
        CriticalIncreaseBuff = 182,
        InterruptModifier = 183,
        DoctorHPBuffs = 184,
        DoctorShortHPBuffs = 185,
        InitiativeDebuffs = 186,
        MetaPhysicistDamageDebuff = 187,
        MongoBuff = 188,
        Rage = 189,
        FirstAidAndTreatmentBuff = 190,
        PerceptionBuffs = 191,
        SenseBuff = 192,
        ConcealmentBuff = 193,
        RifleBuffs = 194,
        AgilityBuff = 195,
        Chemistry_PharmBuff = 196,
        EvasionDebuffs = 197,
        AimedShotBuffs = 198,
        PistolBuff = 199,
        PsychologyBuff = 200,
        NanoDeltaBuffs = 201,
        CharmOther = 202,
        HealDeltaBuff = 203,
        NanoResistanceBuffs = 204,
        Breaking_Entry_DisarmTrapsBuff = 206,
        GrenadeBuffs = 207,
        SneakAttackBuffs = 208,
        MartialArtsBuff = 209,
        NanoProgrammingBuff = 210,
        NPCostDebuff = 211,
        AssaultRifleBuffs = 212,
        RangedEnergyWeaponBuffs = 213,
        BurstBuff = 214,
        NanoDrain_LineA = 215,
        MPPetDamageBuffs = 216,
        MPPetInitiativeBuffs = 217,
        FalseProfession = 218,
        AbsorbACBuff = 219,
        TraderTeamSkillWranglerBuff = 220,
        MetaphysicistMindDamageNanoDebuffs = 221,
        ControlledDestructionBuff = 222,
        Polymorph = 223,
        Fortify = 224,
        PetShortTermDamageBuffs = 225,
        ElianSoul = 226,
        EngineerAuras = 227,
        EngineerAura_Armour = 228,
        EngineerAura_DamageBuff = 229,
        EngineerAura_DamageShieldBuff = 230,
        EngineerAura_ReflectionDamageBuff = 231,
        PetTauntBuff = 232,
        SpeechLine = 233,
        MotivationalSpeechEffect = 234,
        DisarmTrapBuff = 235,
        EngineerDebuffAuras = 236,
        MotivationalSpeechNanoResistBuff = 237,
        DemotivationalSpeeches = 238,
        NanoShutdownDebuff = 239,
        ConcentrationCriticalLine = 240,
        SureshotCriticalLine = 241,
        ExecutionerBuff = 242,
        DamageShieldUpgrades = 243,
        _1HEdgedBuff = 244,
        MultiwieldBuff = 245,
        ControlledRageBuff = 246,
        KinofTarasque = 247,
        MorphHeal = 248,
        PackHunterBase = 249,
        PackHunterBuff = 250,
        AdventurerMorphBuff = 251,
        DamageBuff_LineC = 252,
        FixerSuppressorBuff = 253,
        ChestBuffLine = 254,
        FixerLongHoT = 255,
        Fear = 256,
        FixerNCUBuff = 257,
        TraderTeamHeals1 = 258,
        TraderTeamHeals2 = 259,
        TraderTeamHeals3 = 260,
        TraderTeamHeals4 = 261,
        TraderTeamHeals5 = 262,
        TraderTeamHeals6 = 263,
        TraderTeamHeals7 = 264,
        TraderTeamHeals8 = 265,
        TraderTeamHeals9 = 266,
        TraderTeamHeals10 = 267,
        TraderTeamHeals11 = 268,
        TraderTeamHeals12 = 269,
        TraderTeamHeals13 = 270,
        TraderTeamHeals14 = 271,
        TraderTeamHeals15 = 272,
        TraderTeamHeals16 = 273,
        TraderTeamHeals17 = 274,
        UNUSED1 = 275,
        TowerSmokeBuffEffects = 276,
        DroneTowerBuff = 277,
        EnforcerPiercingBuff = 278,
        EnforcerMeleeEnergyBuff = 279,
        SoldierShotgunBuff = 280,
        SoldierFullAutoBuff = 281,
        CompleteHealingLine = 282,
        SelfRoot_SnareResistBuff = 283,
        OtherRoot_SnareResistBuff = 284,
        PetSnare_RootResistanceBuff = 285,
        EngineerSpecialAttackAbsorber = 286,
        Ransack_DepriveResistBuff = 287,
        EngineerPetAOESnareBuff = 288,
        TemporalChaliceVisualEffectBuff = 289,
        TeporaryRoot_SnareResistanceBuff = 290,
        MongoHoTComponent = 291,
        UnhallowedForceLine = 292,
        BeaconWarp = 293,
        BurntOutArmorProc = 294,
        HellGunDispelProc = 295,
        PerkLimber = 296,
        PerkDanceOfFools = 297,
        PerkChemicalBlindness = 298,
        PerkPoisonSprinkle = 299,
        PerkSealWounds = 300,
        PerkTranquilizer = 301,
        PerkToxicShock = 302,
        PerkConcussiveShot = 303,
        PerkAssasinate = 304,
        PerkBattlegroupHeal1 = 305,
        PerkBattlegroupHeal2 = 306,
        PerkViralCombination = 307,
        PerkBattlegroupHeal3 = 308,
        PerkBattlegroupHeal4 = 309,
        PerkBioShield = 310,
        PerkBioCocoon = 311,
        PerkBioRejuvenation = 312,
        PerkBioRegrowth = 313,
        PerkChaoticModulation = 314,
        PerkSoftenUp = 315,
        PerkPinpointStrike = 316,
        PerkDeathStrike = 317,
        PerkLayOnHands = 318,
        PerkDevotionalArmor = 319,
        PerkCuringTouch = 320,
        PerkQuickBash = 321,
        PerkCrushBone = 322,
        PerkBringThePain = 323,
        PerkDevastatingBlow = 324,
        PerkBigSmash = 325,
        PerkFollowupSmash = 326,
        PerkBlindsideBlow = 327,
        PerkBureaucraticShuffle = 328,
        PerkSuccumb = 329,
        PerkConfoundWithRules = 330,
        PerkEvasiveStance = 331,
        PerkElementaryTeleportation1 = 332,
        PerkElementaryTeleportation2 = 333,
        PerkElementaryTeleportation3 = 334,
        PerkElementaryTeleportation4 = 335,
        PerkICCNodeTeleportation = 336,
        PerkChannelRage = 337,
        PerkBlessingOfLife = 338,
        PerkLifeblood = 339,
        PerkDrawBlood = 340,
        PerkInstallExplosiveDevices = 341,
        PerkInstallNotumDepletionDevice = 342,
        PerkSuppressivePrimer = 343,
        PerkThermalPrimer = 344,
        PerkLeadership = 345,
        PerkGovernance = 346,
        PerkTheDirector = 347,
        PerkBalanceOfYinandYang = 348,
        PerkReapLife = 349,
        PerkBloodletting = 350,
        PerkVitalShock = 351,
        PerkQuickCut = 352,
        PerkFlay = 353,
        PerkFlurryofCuts = 354,
        PerkRibbonFlesh = 355,
        PerkReconstructDNA = 356,
        PerkViralWipe = 357,
        PerkBreachDefenses = 358,
        PerkNanoHeal = 359,
        PerkExplorationTeleportation1 = 360,
        PerkExplorationTeleportation2 = 361,
        PerkDevour = 362,
        PerkBleedingWounds = 363,
        PerkGuttingBlow = 364,
        PerkHeal = 365,
        PerkInvocation = 366,
        PerkTrollForm = 367,
        PerkDisableNaturalHealing = 368,
        PerkStonefist = 369,
        PerkAvalanche = 370,
        PerkGrasp = 371,
        PerkBearhug = 372,
        PerkGripofColossus = 373,
        PerkRemoval1 = 374,
        PerkRemoval2 = 375,
        PerkPurge1 = 376,
        PerkPurge2 = 377,
        PerkGreatPurge = 378,
        PerkReconstruction = 379,
        PerkTauntBox = 380,
        PerkSiphonLife = 381,
        PerkChaoticEnergy = 382,
        PerkRegainNano = 383,
        PerkNCUBooster = 384,
        PerkLaserPaintTarget = 385,
        PerkWeaponBash = 386,
        PerkTriangulateTarget = 387,
        PerkNapalmSpray = 388,
        PerkMarkofVengeance = 389,
        PerkMarkofSufferance = 390,
        PerkMarkoftheUnclean = 391,
        PerkMarkoftheUnhallowed = 392,
        PerkArmorPiercingShot = 393,
        PerkFindtheFlaw = 394,
        PerkCalledShot = 395,
        PerkTremorHand = 396,
        PerkHarmonizeBodyandMind = 397,
        PerkTaunt = 398,
        PerkCharge = 399,
        PerkHeadbutt = 400,
        PerkHatred = 401,
        PerkGroinKick = 402,
        PerkDeconstruction = 403,
        PerkEncaseinStone = 404,
        PerkDetonateStoneWorks = 405,
        PerkShutdownRemoval1 = 406,
        PerkShutdownRemoval2 = 407,
        PerkEnhancedHeal = 408,
        PerkMaliciousProhibition = 409,
        PerkTeamHeal = 410,
        PerkTreatmentTransfer = 411,
        PerkZapNano = 412,
        PerkNanoShakes = 413,
        PerkStripNano = 414,
        PerkAnnihilateNotumMolecules = 415,
        PerkFadeAnger = 416,
        PerkTapNotumSource = 417,
        PerkAccessNotumSource = 418,
        PerkBlastNano = 419,
        PerkStopNotumFlow = 420,
        PerkNotumOverflow = 421,
        PerkStoneworks = 422,
        PerkCripplePsyche = 423,
        PerkShatterPsyche = 424,
        PerkDominator = 425,
        PerkStab = 426,
        PerkDoubleStab = 427,
        PerkPerforate = 428,
        PerkLacerate = 429,
        PerkImpale = 430,
        PerkGore = 431,
        PerkHecatomb = 432,
        PerkQuickShot = 433,
        PerkDoubleShot = 434,
        PerkDeadeye = 435,
        PerkEnergize = 436,
        PerkPowerVolley = 437,
        PerkPowerShock = 438,
        PerkPowerBlast = 439,
        PerkPowerCombo = 440,
        PerkAtrophy = 441,
        PerkDoomTouch = 442,
        PerkSpiritDissolution = 443,
        PerkFadeArmor = 444,
        PerkShadowBullet = 445,
        PerkNightKiller = 446,
        PerkShadowStab = 447,
        PerkBladeofNight = 448,
        PerkShadowKiller = 449,
        PerkSnipeShot1 = 450,
        PerkSnipeShot2 = 451,
        PerkLegShot = 452,
        PerkEasyShot = 453,
        PerkReinforceSlugs = 454,
        PerkJarringBurst = 455,
        PerkSolidSlug = 456,
        PerkNeutroniumSlug = 457,
        PerkFieldBandage = 458,
        PerkTracer = 459,
        PerkContainedBurst = 460,
        PerkViolence = 461,
        PerkGuardian = 462,
        PerkCure = 463,
        PerkVaccinate = 464,
        PerkCure2 = 465,
        PerkVaccinate2 = 466,
        PerkHaleandHearty = 467,
        PerkTeamHaleandHearty = 468,
        PerkCaptureVigor = 469,
        PerkUnhealedBlight = 470,
        PerkCaptureEssence = 471,
        PerkUnsealedPestilence = 472,
        PerkCaptureSpirit = 473,
        PerkUnsealedContagation = 474,
        PerkCaptureVitality = 475,
        PerkBane = 476,
        PerkDragonfire = 477,
        PerkChiConductor = 478,
        PerkIncapacitate = 479,
        PerkFleshQuiver = 480,
        PerkOboliterate = 481,
        PerkDazzlewithLights = 482,
        PerkCombust = 483,
        PerkThermalDetonation = 484,
        PerkSupernova = 485,
        PerkDeepCuts = 486,
        PerkBladeWhirlwind = 487,
        PerkHonoringTheAncients = 488,
        PerkSeppukuSlash = 489,
        PerkExultation = 490,
        PerkEtheralTouch = 491,
        PerkDimensionalFist = 492,
        PerkDisorient = 493,
        PerkConvulsiveTremor = 494,
        PerkSymbiosis = 495,
        PerkMaliciousSymbiosis = 496,
        PerkMalevolentSymbiosis = 497,
        PerkChtonianSymbiosis = 498,
        PerkQuarkContainmentField = 499,
        PerkAccelerateDecayingQuarks = 500,
        PerkKnowledgeEnhancer = 501,
        PerkEscape = 502,
        PerkSabotageQuarkField = 503,
        PerkIgnitionFlare = 504,
        PerkRitualofDevotion = 505,
        PerkDevourVigor = 506,
        PerkRitualofZeal = 507,
        PerkDevourEssence = 508,
        PerkRitualofSpirit = 509,
        PerkDevourVitality = 510,
        PerkRitualofBlood = 511,
        PerkECM1 = 512,
        PerkECM2 = 513,
        PerkSPECIALAcrobat = 514,
        PerkSPECIALbureaucraticshuffle = 515,
        PerkSPECIALpersuader = 516,
        PerkSPECIALalchemist = 517,
        KeeperDeflect_RiposteBuff = 518,
        FastAttackBuffs = 519,
        ShadeDamageProc_DamageInflictSegment = 520,
        ShadeProcBuff = 521,
        ShadeHP_NPDoTProc_DamageInflictSegment = 522,
        ShadeInitDebuffProc = 523,
        KeeperSanctifierProc_DamageInflictSegment = 524,
        KeeperReaperProc_DamageInflictSegment = 525,
        KeeperProcBuff = 526,
        KeeperAura_HPandNPHeal = 527,
        KeeperAura_Absorb_Reflect_AMSBuff = 528,
        KeeperAura_Damage_SnareReductionBuff = 529,
        KeeperHealAura_Team = 530,
        KeeperNPHealAura_Team = 531,
        KeeperAbsorbAura_Team = 532,
        KeeperAMS_DMSAura_Team = 533,
        KeeperReflectAura_Team = 534,
        KeeperDamageAura_Team = 535,
        KeeperSnareReductionAura_Team = 536,
        PerkSPECIALAssasin = 537,
        AddAllDef_PerkBuff = 538,
        KeeperStr_Stam_AgiBuff = 539,
        PerkSPECIALTinkerer = 540,
        PerkSpecialThief = 541,
        PerkSPECIALStarfall = 542,
        PerkSpecialShadowsneak = 543,
        PerkSpecialKungfuMaster = 544,
        KeeperEvade_Dodge_DuckBuff = 545,
        ShadePiercingBuff = 546,
        DimachBuff = 547,
        PerkAuraOfRevival_HealStopper = 548,
        PerkCommandingPresence = 549,
        PerkDirectorshipBuff = 550,
        PerkChannelingOfNotum_HealStopper = 551,
        PerkTheoreticalResearch = 552,
        PerkStreetSamurai = 553,
        PerkSpecialForces = 554,
        PerkSMGMastery = 555,
        PerkNanoSurgeon556 = 556,
        PerkHeavyRanged = 557,
        PerkGridNCU = 558,
        PerkEnhancedNanoDamage = 559,
        GMNanobuff = 560,
        PerkNanoSurgeon561 = 561,
        UNUSED2 = 562,
        GeneralDimachBuff = 563,
        GeneralMeleeMultipleBuff = 564,
        MonsterWaveSpawn1 = 565,
        MonsterWaveSpawn2 = 566,
        MonsterWaveSpawn3 = 567,
        MonsterWaveSpawn4 = 568,
        MonsterWaveSpawn5 = 569,
        MonsterWaveSpawn6 = 570,
        MonsterWaveSpawn7 = 571,
        MonsterWaveSpawn8 = 572,
        MonsterWaveSpawn9 = 573,
        MonsterWaveSpawn10 = 574,
        BattlegroupHeal = 575,
        Psy_IntBuff = 576,
        BioShielding = 577,
        BioCocoon = 578,
        BioRejuvenation = 579,
        BioRegrowth = 580,
        GeneralRangedMultipleBuff = 581,
        DOTStrainC = 582,
        DevotionalArmor = 583,
        ScaleRepair = 584,
        SlobberWounds = 585,
        LickWoundsNA = 586,
        SLNanopointDrain = 587,
        NanoPointHeals = 588,
        BlessingofLife = 589,
        Lifeblood = 590,
        DrawBlood = 591,
        HeavyWeaponsBuffs = 592,
        EtherealTouch = 593,
        ConvulsiveTremor = 594,
        NanoRecharge = 595,
        HealthRecharge = 596,
        DamageChangeBuffs = 597,
        BonfireRecharger = 598,
        RitualofDevotion = 599,
        RitualofZeal = 600,
        RitualofSpirit = 601,
        RitualofBlood = 602,
        MonsterEffect1 = 603,
        MonsterEffect2 = 604,
        MonsterEffect3 = 605,
        MonsterEffect4 = 606,
        MonsterEffect5 = 607,
        MonsterEffect6 = 608,
        MonsterEffect7 = 609,
        MonsterEffect8 = 610,
        ShortTermXPGain = 611,
        DoubleStabBleedingWounds = 612,
        LacerateBleedingWounds = 613,
        GoreBleedingWounds = 614,
        HecatombBleedingWounds = 615,
        MonsterEffect_Breakable = 616,
        MonsterEffect_DuringFight = 617,
        PerkCleave = 618,
        PerkTransfix = 619,
        PerkPainLance = 620,
        PerkSliceAndDice = 621,
        PerkPulverize = 622,
        PerkHammerAndAnvil = 623,
        PerkOverwhelmingMight = 624,
        PerkSeismicSmash = 625,
        PainLanceDoT = 626,
        EnforcerTauntProcs = 627,
        EnforcerTauntProcsFearbringer = 628,
        EnforcerTauntProcsIrebringer = 629,
        EnforcerTauntProcsWrathbringer = 630,
        EnforcerTauntProcsHatebringer = 631,
        EnforcerTauntProcsRagebringer = 632,
        EnforcerTauntProcsDreadbringer = 633,
        AccelerateDecayingQuarksDebuff = 634,
        AgentDamageProc_DamageInflictSegment = 635,
        AgentProcBuff = 636,
        MonsterEffect_MainLoop = 637,
        Atrophy = 638,
        DeepCuts = 639,
        TraderDebuffACNanos = 640,
        LegShot = 641,
        CrushBone = 642,
        NanoResistanceDebuff_LineA = 643,
        DebuffNanoACHeavy = 644,
        CalledShotBleedingWounds = 645,
        Energize = 646,
        MarkofVengeance = 647,
        MarkofSufferance = 648,
        MarkoftheUnclean = 649,
        MarkoftheUnhallowed = 650,
        ToxicShock = 651,
        ToxicShockProcEffect = 652,
        DodgetheBlame = 653,
        ConfoundwithRules = 654,
        Succumb = 655,
        TrollForm = 656,
        DisableNaturalHealing = 657,
        MPDamageDebuffLineA = 658,
        MPDamageDebuffLineB = 659,
        NanoShakes = 660,
        TapNotumSource = 661,
        BlastNano = 662,
        StopNotumFlow = 663,
        NotumOverflow = 664,
        BladeofNight = 665,
        Violence = 666,
        ViolenceController = 667,
        Guardian = 668,
        TotalMirrorShield = 669,
        DazzlewithLights = 670,
        KnowledgeEnhancer = 671,
        BleedingWounds = 672,
        FixerDodgeBuffLine = 673,
        HammerandAnvil = 674,
        ZapNano = 675,
        ChannelRage = 676,
        ChaoticModulation = 677,
        FreakStrengthStun = 678,
        FreakStrengthSelfStun = 679,
        AgentEscapeNanos = 680,
        Reconstruction681 = 681,
        TauntBox682 = 682,
        SiphonBox683 = 683,
        GadgeteerPetProcs = 684,
        GroinKick = 685,
        Reconstruction686 = 686,
        TauntBox687 = 687,
        SiphonBox688 = 688,
        Deconstruction = 689,
        InstallExplosiveDeviceDoT = 690,
        InstallNotumDepletionDeviceDoT = 691,
        InstallExplosiveDeviceCountdown = 692,
        InstallNotumDepletionDeviceCountdown = 693,
        ShadowlandReflectBase = 694,
        Blackstep = 695,
        ObscureVision = 696,
        GatherDarkness = 697,
        Silence = 698,
        SilenceDebuff = 699,
        Misery = 700,
        Death = 701,
        PathofDarkness = 702,
        PathofDarknessDebuff = 703,
        RoadToDarkness = 704,
        RoadToDarknessDebuff = 705,
        TheChoice_Omni = 706,
        TheChoiceDebuff_Omni = 707,
        Blackfist = 708,
        SlamofDarkness = 709,
        SlamofDarknessDebuff = 710,
        ScreamofDeath = 711,
        ScreamofDeathDebuff = 712,
        Lightstep = 713,
        GatherLight = 714,
        RainofLight = 715,
        RainofLightBuff = 716,
        Morning = 717,
        MorningDebuff = 718,
        Hope = 719,
        HopeBuff = 720,
        HopeDebuff = 721,
        Life = 722,
        PathofLight = 723,
        TunnelofLight = 724,
        TunnelofLightBuff = 725,
        TheChoice_Clan = 726,
        ScreenofLight = 727,
        ShieldofLight = 728,
        ShieldofLightBuff = 729,
        FortressofLight = 730,
        FortressofLightBuff = 731,
        MiseryBuff = 732,
        MiseryDebuff = 733,
        QuarkContainmentField = 734,
        Fury = 735,
        ReinforcedSlugs = 736,
        AffectedbyNanoHeal = 737,
        ShadowlandBindandRecall = 738,
        PerformedRitualofDevotion = 739,
        PerformedRitualofZeal = 740,
        PerformedRitualofSpirit = 741,
        PerformedRitualofBlood = 742,
        PerformedDevourVigor = 743,
        PerformedDevourEssence = 744,
        PerformedDevourVitality = 745,
        PerformedStab = 746,
        PerformedPerforate = 747,
        PerformedImpale = 748,
        PerformedDoubleStab = 749,
        PerformedLacerate = 750,
        PerformedGore = 751,
        PerformedHecatomb = 752,
        PerformedCaptureVigor = 753,
        PerformedCaptureEssence = 754,
        PerformedCaptureSpirit = 755,
        PerformedCaptureVitality = 756,
        AffectedbyTaintWounds = 757,
        PerformedUnsealedBlight = 758,
        PerformedUnsealedPestilence = 759,
        PerformedUnsealedContagion = 760,
        TransitionOfErgo = 761,
        InsuranceAgent = 762,
        InsuranceClaim = 763,
        AffectedbyInsuranceClaim = 764,
        RegainNano = 765,
        GroveHealingMultiplier = 766,
        InstinctiveControl = 767,
        SpecialAttackAbsorberBase = 768,
        TotalFocus = 769,
        SoldierDamageBase = 770,
        AffectedByDefensiveStance = 771,
        DefensiveStance = 772,
        AgentDetauntProc_DetauntSegment = 773,
        AffectedbyDeceptiveStance = 774,
        DeceptiveStance = 775,
        AffectedbyConsumetheSoul = 776,
        ShortTermHPBuff = 777,
        AffectedbySpiritofBlessing = 778,
        AffectedbySpiritofPurity = 779,
        SpiritofBlessing = 780,
        SpiritofPurity = 781,
        WaitForAttackEffectNano2 = 782,
        DuringFightNanoEffect2 = 783,
        DanceofFools = 784,
        EnvironmentalDamage = 785,
        FixerRunspeedBase = 786,
        AIPERKBlur = 787,
        AIPERKSacrifice = 788,
        MINIDoT = 789,
        ZixLine = 790,
        AIAMSmodifierproc = 791,
        AIPERKSilentPlague = 792,
        AIPERKInsight = 793,
        AIPERKAssumeTarget = 794,
        Daring = 795,
        LeetEmpower = 796,
        Link = 797,
        NoTerraform = 798,
        BossRoot = 799,
        Cocoon = 800,
        NTAreaNukes = 801,
        AELevelSpawn = 802,
        Scones = 803,
        PrivacyShield = 804,
        BatterUp = 805,
        ArmorDamage = 806,
        HealingConstructEmpowerment = 807,
        PH = 808,
        DamagetoNano = 809,
        MesmerizationConstructEmpowerment = 810,
        EngineerMiniaturization = 811,
        ResearchAbility1 = 812,
        ResearchAbility2 = 813,
        TraderAAODrain = 814,
        MartialArtistBowBuffs = 815,
        PetDefensiveNanos = 816,
        PetDamageOverTimeResistNanos = 817,
        ColdBlooded = 818,
        SingedFists = 819,
        AMS = 820,
        ShovelBuffs = 821,
        AncientBlessings = 822,
        AugmentedMirrorShieldNano = 823,
        NullitySphereNano = 824,
        DOTRemoval = 825,
        TraderNanoTheft1 = 826,
        TraderNanoTheft2 = 827,
        HealthandNanoOverTimeDrain = 828,
        HealthandNanoOverTimeTransfer = 829,
        TrueProfession = 830,
        ShieldoftheObedientServant = 831,
        NTAreaNukes2 = 832,
        BureaucratResearchStun1 = 833,
        BureaucratResearchStun2 = 834,
        NanoResistBuff = 835,
        AAOBuffs = 836,
        AffectedbyOFABDebuff = 837,
        DustBrigadeTurretsI = 838,
        DustBrigadeTurretsII = 839,
        DustBrigadeTurretsIII = 840,
        AdventurerDamageModifier = 841,
        DeTaunt = 842,
        PetHealDelta843 = 843,
        HealthDrain = 844,
        DamageDrain = 845,
        SkillLockModifierDebuff847 = 847,
        Incapacitate = 849,
        PetHealDelta850 = 850,
        ReanimatedCloakBuffs = 851,
        ReanimatedCloakBlocker = 852,
        ReanimatedCloakDebuffs = 853,
        AggressiveConstructEmpowerment = 854,
        MaxNanoBuffs = 855,
        NanoDrain_LineB = 856,
        NotumShield = 857,
        NanoBurst_CyberdeckSpecial = 858,
        MartialArtistHOTLineA = 859,
        Malpractice = 860,
        WeaponEffectAdd_On2 = 861,
        NanoResistDebuffProc = 862,
        MPAttackPetDamageType = 863,
        MagnifyingGlassBuffs = 864,
        BreathingLine1 = 865,
        BreathingLine2 = 866,
        BreathingLine3 = 867,
        EvasionDebuffs_Agent = 868,
        DBPFTeleportA = 869,
        DBPFTeleportB = 870,
        DBPFTeleportC = 871,
        DBPFTeleportD = 872,
        DBPFTeleportE = 873,
        DBPFTeleportF = 874,
        DBPFTeleportX = 875,
        MagnifyingGlassAttunementBX11 = 876,
        MagnifyingGlassAttunementWQEL = 877,
        MagnifyingGlassAttunementMVCN = 878,
        MagnifyingGlassAttunementZLQ6 = 879,
        AlienDropshipShield1insidewest = 880,
        AlienDropshipShield2insideeast = 881,
        AlienDropshipShield3insidenorth = 882,
        Fear_PVP = 883,
        Knockback = 884,
        Fear_Cooldown = 885,
        ReverseKnockback = 886,
        UnremovableSnare = 887,
        TraderShutdownSkillDebuff = 889,
        TraderShutdownSkillBuff = 890,
        KeeperFearImmunity = 900,
        FixerFearImmunity = 901,
        EnduranceSkin = 909,
        PvPEnabled = 910,
        DarkRuinsRootandSnare = 911,
        Vehicles = 914,
        PrototypeNanoformula = 916,
        BorrowReflect = 922,
        TotalControl = 924,
        TrollFormRunDebuff = 925,
        SocialPets = 926,
        MarkofthePious = 927,
        Focus = 928,
        Loophole = 929,
        OptimizeBotProtocol = 930,
        FreakShield = 931,
        FlimFocus = 932,
        BringThePain = 933,
        ChemicalBlindness = 934,
        PoisonSprinkle = 935,
        MongoFury = 936,
        WitoftheAtrox = 937,
        WayofTheAtrox = 938,
        NotumDomination = 939,
        NotumSpring = 940,
        BlindedbyDelights = 941,
        Derivate = 942,
        DizzyingHeights = 943,
        SprainedAnkle = 944,
        Feel = 945,
        Propaganda = 946,
        TreatmentTransfer = 947,
        GeneralPerceptionBuff = 949,
        SingleTargetHealing = 951,
        TeamHealing = 952,
        KyrOzchGenePool=956,
        AlienParasite = 957,
        MindControl = 958,
        ExperienceConstructs_XPBonus = 959,
        NemesisNanoPrograms = 1000,
        AADBuffs = 1002,
        Stun = 1003,
        AOEMezz = 1004,
        AOESnare = 1005,
        AOERoot = 1006,
        SnareRemovalSelf = 1007,
        SnareRemovalOther = 1008,
        SnareRemovalTeam = 1009,
        RootRemovalSelf = 1010,
        RootRemovalOther = 1011,
        RootRemovalTeam = 1012,
        PetRoot, SnareandMezzRemoval = 1013,
        PetHealing = 1014,
        AttackPets = 1015,
        HealPets = 1016,
        SupportPets = 1017,
        PetSacrifice = 1018,
        PetWarp = 1019,
        PetProc_LineB = 1020,
        PetAOESnare = 1021,
        Charm_Short = 1022,
        PetProc_LineA = 1023,
        DamageToPet = 1024,
        Nukes = 1025,
        AlphaNukes = 1026,
        FinishingNukes = 1027,
        SpecialEffectNukes = 1028,
        BossBuffs = 1029,
        SelfGrid = 1030,
        TeamGrid = 1031,
        EmergencyGrid = 1032,
        ShadowlandsMaps = 1033,
        TeamRunSpeedBuffs = 1034,
        SpiritDrain = 1035,
        SummonItem = 1036,
        Taunt = 1037,
        AOETauntDOT = 1038,
        FixerGrid = 1039,
        NanoDeltaDebuff = 1040,
        Nuke = 1041,
        AlphaNuke = 1042,
        OmegaNuke = 1043,
        AOENuke = 1044,
        ResurrectionSicknessRemoval = 1045,
        FoodandDrinkBuffs = 1046,
        PetDebuffCleanse = 1047,
        ProximityRangeDebuff = 1048,
        EmergencySneak = 1049,
        HealDeltaDebuff = 1050,
        DrainHeal = 1051,
        CriticalDecreaseBuff = 1052,
        SkillLockModifierDebuff1053 = 1053,
        ICCSurveillanceSoftware = 1054,
        HealReactivityMultiplierBuff = 1055,
        HealReactivityMultiplierDebuff = 1056,
        Charge = 1057,
        MartialArtistZazenStance = 1058,
        MartialArtistHOT_LineB = 1059,
        TraderAADDrain = 1060,
        NanoOverTime_LineB = 1061,
        NanoDamageMultiplierBuffs = 1062,
    }
}
