﻿// <copyright file="IccDataReader.LutTests.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Tests.Icc
{
    using Xunit;

    public class IccDataReaderLutTests
    {
        [Theory]
        [MemberData(nameof(IccTestDataLut.ClutTestData), MemberType = typeof(IccTestDataLut))]
        internal void ReadClut(byte[] data, IccClut expected, int inChannelCount, int outChannelCount, bool isFloat)
        {
            IccDataReader reader = CreateReader(data);

            IccClut output = reader.ReadClut(inChannelCount, outChannelCount, isFloat);

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataLut.Clut8TestData), MemberType = typeof(IccTestDataLut))]
        internal void ReadClut8(byte[] data, IccClut expected, int inChannelCount, int outChannelCount, byte[] gridPointCount)
        {
            IccDataReader reader = CreateReader(data);

            IccClut output = reader.ReadClut8(inChannelCount, outChannelCount, gridPointCount);

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataLut.Clut16TestData), MemberType = typeof(IccTestDataLut))]
        internal void ReadClut16(byte[] data, IccClut expected, int inChannelCount, int outChannelCount, byte[] gridPointCount)
        {
            IccDataReader reader = CreateReader(data);

            IccClut output = reader.ReadClut16(inChannelCount, outChannelCount, gridPointCount);

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataLut.ClutF32TestData), MemberType = typeof(IccTestDataLut))]
        internal void ReadClutF32(byte[] data, IccClut expected, int inChannelCount, int outChannelCount, byte[] gridPointCount)
        {
            IccDataReader reader = CreateReader(data);

            IccClut output = reader.ReadClutF32(inChannelCount, outChannelCount, gridPointCount);

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataLut.Lut8TestData), MemberType = typeof(IccTestDataLut))]
        internal void ReadLut8(byte[] data, IccLut expected)
        {
            IccDataReader reader = CreateReader(data);

            IccLut output = reader.ReadLut8();

            Assert.Equal(expected, output);
        }

        [Theory]
        [MemberData(nameof(IccTestDataLut.Lut16TestData), MemberType = typeof(IccTestDataLut))]
        internal void ReadLut16(byte[] data, IccLut expected, int count)
        {
            IccDataReader reader = CreateReader(data);

            IccLut output = reader.ReadLut16(count);

            Assert.Equal(expected, output);
        }

        private IccDataReader CreateReader(byte[] data)
        {
            return new IccDataReader(data);
        }
    }
}
