namespace SabreTools.Hashing.RipeMD
{
    // <see href="https://cdn.standards.iteh.ai/samples/39876/10f9f9f4bb614eaaaeba7e157e183ca3/ISO-IEC-10118-3-2004.pdf"/>
    internal static class Constants
    {
        #region RIPEMD-128

        public const uint RMD128Round00To15 = 0x00000000;
        public const uint RMD128Round16To31 = 0x5A827999;
        public const uint RMD128Round32To47 = 0x6ED9EBA1;
        public const uint RMD128Round48To63 = 0x8F1BBCDC;

        public const uint RMD128RoundPrime00To15 = 0x50A28BE6;
        public const uint RMD128RoundPrime16To31 = 0x5C4DD124;
        public const uint RMD128RoundPrime32To47 = 0x6D703EF3;
        public const uint RMD128RoundPrime48To63 = 0x00000000;

        public const uint RMD128Y0 = 0x67452301;
        public const uint RMD128Y1 = 0xEFCDAB89;
        public const uint RMD128Y2 = 0x98BADCFE;
        public const uint RMD128Y3 = 0x10325476;

        #endregion

        #region RIPEMD-160

        public const uint RMD160Round00To15 = 0x00000000;
        public const uint RMD160Round16To31 = 0x5A827999;
        public const uint RMD160Round32To47 = 0x6ED9EBA1;
        public const uint RMD160Round48To63 = 0x8F1BBCDC;
        public const uint RMD160Round64To79 = 0xA953FD4E;

        public const uint RMD160RoundPrime00To15 = 0x50A28BE6;
        public const uint RMD160RoundPrime16To31 = 0x5C4DD124;
        public const uint RMD160RoundPrime32To47 = 0x6D703EF3;
        public const uint RMD160RoundPrime48To63 = 0x7A6D76E9;
        public const uint RMD160RoundPrime64To79 = 0x00000000;

        public const uint RMD160Y0 = 0x67452301;
        public const uint RMD160Y1 = 0xEFCDAB89;
        public const uint RMD160Y2 = 0x98BADCFE;
        public const uint RMD160Y3 = 0x10325476;
        public const uint RMD160Y4 = 0xC3D2E1F0;

        /// <summary>
        /// t_i
        /// </summary>
        public static readonly byte[] RMD160Ti =
        [
            11, 14, 15, 12,  5,  8,  7,  9,
            11, 13, 14, 15,  6,  7,  9,  8,
             7,  6,  8, 13, 11,  9,  7, 15,
             7, 12, 15,  9, 11,  7, 13, 12,
            11, 13,  6,  7, 14,  9, 13, 15,
            14,  8, 13,  6,  5, 12,  7,  5,
            11, 12, 14, 15, 14, 15,  9,  8,
             9, 14,  5,  6,  8,  6,  5, 12,
             9, 15,  5, 11,  6,  8, 13, 12,
             5, 12, 13, 14, 11,  8,  5,  6,
        ];

        /// <summary>
        /// t'_i
        /// </summary>
        public static readonly byte[] RMD160Tpi =
        [
             8,  9,  9, 11, 13, 15, 15,  5,
             7,  7,  8, 11, 14, 14, 12,  6,
             9, 13, 15,  7, 12,  8,  9, 11,
             7,  7, 12,  7,  6, 15, 13, 11,
             9,  7, 15, 11,  8,  6,  6, 14,
            12, 13,  5, 14, 13, 13,  7,  5,
            15,  5,  8, 11, 14, 14,  6, 14,
             6,  9, 12,  9, 12,  5, 15,  8,
             8,  5, 12,  9, 12,  5, 14,  6,
             8, 13,  6,  5, 15, 13, 11, 11,
        ];

        /// <summary>
        /// a_i
        /// </summary>
        public static readonly byte[] RMD160Ai =
        [
             0,  1,  2,  3,  4,  5,  6,  7,
             8,  9, 10, 11, 12, 13, 14, 15,
             7,  4, 13,  1, 10,  6, 15,  3,
            12,  0,  9,  5,  2, 14, 11,  8,
             3, 10, 14,  4,  9, 15,  8,  1,
             2,  7,  0,  6, 13, 11,  5, 12,
             1,  9, 11, 10,  0,  8, 12,  4,
            13,  3,  7, 15, 14,  5,  6,  2,
             4,  0,  5,  9,  7, 12,  2, 10,
            14,  1,  3,  8, 11,  6, 15, 13,
        ];

        /// <summary>
        /// a'_i
        /// </summary>
        public static readonly byte[] RMD160Api =
        [
             5, 14,  7,  0,  9,  2, 11,  4,
            13,  6, 15,  8,  1, 10,  3, 12,
             6, 11,  3,  7,  0, 13,  5, 10,
            14, 15,  8, 12,  4,  9,  1,  2,
            15,  5,  1,  3,  7, 14,  6,  9,
            11,  8, 12,  2, 10,  0,  4, 13,
             8,  6,  4,  1,  3, 11, 15,  0,
             5, 12,  2, 13,  9,  7, 10, 14,
            12, 15, 10,  4,  1,  5,  8,  7,
             6,  2, 13, 14,  0,  3,  9, 11,
        ];

        #endregion
    }
}