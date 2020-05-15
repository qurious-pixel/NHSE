﻿using static NHSE.Core.TerrainUnitModel;

namespace NHSE.Core
{
    public enum TerrainUnitModel : ushort
    {
        Base = 0x00,
        River0A = 0x01,
        River1A = 0x04,
        River2A = 0x07,
        River2B = 0x08,
        River2C = 0x09,
        River3A = 0x0A,
        River3B = 0x0B,
        River3C = 0x0C,
        River4A = 0x0D,
        River4B = 0x0E,
        River4C = 0x0F,
        River5A = 0x10,
        River5B = 0x11,
        River6A = 0x12,
        River6B = 0x13,
        River7A = 0x14,
        River8A = 0x15,
        Cliff0A = 0x16,
        Cliff0A_2 = 0x17,
        Cliff0A_3 = 0x18,
        Cliff1A = 0x19,
        Cliff1A_2 = 0x1A,
        Cliff1A_3 = 0x1B,
        Cliff2A = 0x1C,
        Cliff2C = 0x1D,
        Cliff3A = 0x1E,
        Cliff3B = 0x1F,
        Cliff3C = 0x20,
        Cliff4A = 0x21,
        Cliff4B = 0x22,
        Cliff4C = 0x23,
        Cliff5A = 0x24,
        Cliff5B = 0x25,
        Cliff6A = 0x26,
        Cliff6B = 0x27,
        Cliff7A = 0x28,
        Cliff8 = 0x29,
        Fall101 = 0x3A,
        Fall100 = 0x3B,
        Fall300 = 0x3C,
        Fall301 = 0x3D,
        Fall302 = 0x3E,
        Fall200 = 0x3F,
        Fall201 = 0x40,
        Fall202 = 0x41,
        Fall400 = 0x42,
        Fall401 = 0x43,
        Fall402 = 0x44,
        Fall403 = 0x45,
        Fall404 = 0x46,
        RoadSoil0A = 0x47,
        RoadSoil1A = 0x48,
        RoadSoil0B = 0x49,
        RoadSoil1B = 0x4B,
        RoadSoil1C = 0x4C,
        RoadSoil2A = 0x4D,
        RoadSoil2B = 0x4E,
        RoadSoil2C = 0x4F,
        RoadSoil3A = 0x50,
        RoadSoil3B = 0x51,
        RoadSoil3C = 0x52,
        RoadSoil4A = 0x53,
        RoadSoil4B = 0x54,
        RoadSoil4C = 0x55,
        RoadSoil5A = 0x56,
        RoadSoil5B = 0x57,
        RoadSoil6A = 0x58,
        RoadSoil6B = 0x59,
        RoadSoil7A = 0x5A,
        RoadSoil8A = 0x5B,
        RoadStone0A = 0x5C,
        RoadStone0B = 0x5D,
        RoadStone1A = 0x5F,
        RoadStone1B = 0x60,
        RoadStone1C = 0x61,
        RoadStone2A = 0x62,
        RoadStone2B = 0x63,
        RoadStone2C = 0x64,
        RoadStone3A = 0x65,
        RoadStone3B = 0x66,
        RoadStone3C = 0x67,
        RoadStone4A = 0x68,
        RoadStone4B = 0x69,
        RoadStone4C = 0x6A,
        RoadStone5A = 0x6B,
        RoadStone5B = 0x6C,
        RoadStone6A = 0x6D,
        RoadStone6B = 0x6E,
        RoadStone7A = 0x6F,
        RoadStone8A = 0x70,
        Fall103 = 0x71,
        Fall102 = 0x72,
        Fall303 = 0x73,
        Fall304 = 0x74,
        Fall305 = 0x75,
        Fall306 = 0x76,
        Fall307 = 0x77,
        Fall308 = 0x78,
        Fall203 = 0x79,
        Fall204 = 0x7A,
        Fall205 = 0x7B,
        Fall206 = 0x7C,
        Fall207 = 0x7D,
        Fall208 = 0x7E,
        Fall405 = 0x7F,
        Fall406 = 0x80,
        Fall407 = 0x81,
        Fall408 = 0x82,
        Fall410 = 0x83,
        Fall409 = 0x84,
        Fall411 = 0x85,
        Fall412 = 0x86,
        Fall414 = 0x87,
        Fall413 = 0x88,
        Fall415 = 0x89,
        Fall416 = 0x8A,
        Fall418 = 0x8B,
        Fall417 = 0x8C,
        Fall419 = 0x8D,
        Fall420 = 0x8E,
        Fall422 = 0x8F,
        Fall421 = 0x90,
        Fall423 = 0x91,
        Fall424 = 0x92,
        Cliff2B = 0x93,
        RoadBrick0A = 0x94,
        RoadBrick0B = 0x95,
        RoadBrick1A = 0x97,
        RoadBrick1B = 0x98,
        RoadBrick1C = 0x99,
        RoadBrick2A = 0x9A,
        RoadBrick2B = 0x9B,
        RoadBrick2C = 0x9C,
        RoadBrick3A = 0x9D,
        RoadBrick3B = 0x9E,
        RoadBrick3C = 0x9F,
        RoadBrick4A = 0xA0,
        RoadBrick4B = 0xA1,
        RoadBrick4C = 0xA2,
        RoadBrick5A = 0xA3,
        RoadBrick5B = 0xA4,
        RoadBrick6A = 0xA5,
        RoadBrick6B = 0xA6,
        RoadBrick7A = 0xA7,
        RoadBrick8A = 0xA8,
        RoadDarkSoil0A = 0xA9,
        RoadDarkSoil0B = 0xAA,
        RoadDarkSoil1A = 0xAC,
        RoadDarkSoil1B = 0xAD,
        RoadDarkSoil1C = 0xAE,
        RoadDarkSoil2A = 0xAF,
        RoadDarkSoil2B = 0xB0,
        RoadDarkSoil2C = 0xB1,
        RoadDarkSoil3A = 0xB2,
        RoadDarkSoil3B = 0xB3,
        RoadDarkSoil3C = 0xB4,
        RoadDarkSoil4A = 0xB5,
        RoadDarkSoil4B = 0xB6,
        RoadDarkSoil4C = 0xB7,
        RoadDarkSoil5A = 0xB8,
        RoadDarkSoil5B = 0xB9,
        RoadDarkSoil6A = 0xBA,
        RoadDarkSoil6B = 0xBB,
        RoadDarkSoil7A = 0xBC,
        RoadDarkSoil8A = 0xBD,
        RoadFanPattern0A = 0xBE,
        RoadFanPattern0B = 0xBF,
        RoadFanPattern1A = 0xC1,
        RoadFanPattern1B = 0xC2,
        RoadFanPattern1C = 0xC3,
        RoadFanPattern2A = 0xC4,
        RoadFanPattern2B = 0xC5,
        RoadFanPattern2C = 0xC6,
        RoadFanPattern3A = 0xC7,
        RoadFanPattern3B = 0xC8,
        RoadFanPattern3C = 0xC9,
        RoadFanPattern4A = 0xCA,
        RoadFanPattern4B = 0xCB,
        RoadFanPattern4C = 0xCC,
        RoadFanPattern5A = 0xCD,
        RoadFanPattern5B = 0xCE,
        RoadFanPattern6A = 0xCF,
        RoadFanPattern6B = 0xD0,
        RoadFanPattern7A = 0xD1,
        RoadFanPattern8A = 0xD2,
        RoadSand0A = 0xD3,
        RoadSand0B = 0xD4,
        RoadSand1A = 0xD6,
        RoadSand1B = 0xD7,
        RoadSand1C = 0xD8,
        RoadSand2A = 0xD9,
        RoadSand2B = 0xDA,
        RoadSand2C = 0xDB,
        RoadSand3A = 0xDC,
        RoadSand3B = 0xDD,
        RoadSand3C = 0xDE,
        RoadSand4A = 0xDF,
        RoadSand4B = 0xE0,
        RoadSand4C = 0xE1,
        RoadSand5A = 0xE2,
        RoadSand5B = 0xE3,
        RoadSand6A = 0xE4,
        RoadSand6B = 0xE5,
        RoadSand7A = 0xE6,
        RoadSand8A = 0xE7,
        RoadTile0A = 0xE8,
        RoadTile0B = 0xE9,
        RoadTile1A = 0xEB,
        RoadTile1B = 0xEC,
        RoadTile1C = 0xED,
        RoadTile2A = 0xEE,
        RoadTile2B = 0xEF,
        RoadTile2C = 0xF0,
        RoadTile3A = 0xF1,
        RoadTile3B = 0xF2,
        RoadTile3C = 0xF3,
        RoadTile4A = 0xF4,
        RoadTile4B = 0xF5,
        RoadTile4C = 0xF6,
        RoadTile5A = 0xF7,
        RoadTile5B = 0xF8,
        RoadTile6A = 0xF9,
        RoadTile6B = 0xFA,
        RoadTile7A = 0xFB,
        RoadTile8A = 0xFC,
        RoadWood0A = 0xFD,
        RoadWood0B = 0xFE,
        RoadWood1A = 0x100,
        RoadWood1B = 0x101,
        RoadWood1C = 0x102,
        RoadWood2A = 0x103,
        RoadWood2B = 0x104,
        RoadWood2C = 0x105,
        RoadWood3A = 0x106,
        RoadWood3B = 0x107,
        RoadWood3C = 0x108,
        RoadWood4A = 0x109,
        RoadWood4B = 0x10A,
        RoadWood4C = 0x10B,
        RoadWood5A = 0x10C,
        RoadWood5B = 0x10D,
        RoadWood6A = 0x10E,
        RoadWood6B = 0x10F,
        RoadWood7A = 0x110,
        RoadWood8A = 0x111,
    }

    public static class TerrainUnitModelExtensions
    {
        public static bool IsRoad(this TerrainUnitModel t) => t >= RoadBrick0A || (RoadSoil0A <= t && t <= RoadStone8A);
        public static bool IsRoadWood(this TerrainUnitModel t) => RoadWood0A <= t && t <= RoadWood8A;
        public static bool IsRoadTile(this TerrainUnitModel t) => RoadTile0A <= t && t <= RoadTile8A;
        public static bool IsRoadSand(this TerrainUnitModel t) => RoadSand0A <= t && t <= RoadSand8A;
        public static bool IsRoadPattern(this TerrainUnitModel t) => RoadFanPattern0A <= t && t <= RoadFanPattern8A;
        public static bool IsRoadDarkSoil(this TerrainUnitModel t) => RoadDarkSoil0A <= t && t <= RoadDarkSoil8A;
        public static bool IsRoadBrick(this TerrainUnitModel t) => RoadBrick0A <= t && t <= RoadBrick8A;
        public static bool IsRoadStone(this TerrainUnitModel t) => RoadStone0A <= t && t <= RoadStone8A;
        public static bool IsRoadSoil(this TerrainUnitModel t) => RoadSoil0A <= t && t <= RoadSoil8A;

        public static bool IsFall(this TerrainUnitModel t) => (Fall101 <= t && t <= Fall404) || (Fall103 <= t && t <= Fall424);
        public static bool IsCliff(this TerrainUnitModel t) => (Cliff0A <= t && t <= Cliff8) || (t == Cliff2B);
        public static bool IsRiver(this TerrainUnitModel t) => River0A <= t && t <= River8A;
    }
}