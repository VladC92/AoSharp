﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KnuBotAppendTextMessage.cs" company="SmokeLounge">
//   Copyright © 2013 SmokeLounge.
//   This program is free software. It comes without any warranty, to
//   the extent permitted by applicable law. You can redistribute it
//   and/or modify it under the terms of the Do What The Fuck You Want
//   To Public License, Version 2, as published by Sam Hocevar. See
//   http://www.wtfpl.net/ for more details.
// </copyright>
// <summary>
//   Defines the KnuBotAppendTextMessage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using AOSharp.Common.GameData;

namespace SmokeLounge.AOtomation.Messaging.Messages.N3Messages
{
    using SmokeLounge.AOtomation.Messaging.GameData;
    using SmokeLounge.AOtomation.Messaging.Serialization;
    using SmokeLounge.AOtomation.Messaging.Serialization.MappingAttributes;

    [AoContract((int)N3MessageType.KnubotAppendText)]
    public class KnuBotAppendTextMessage : N3Message
    {
        #region Constructors and Destructors

        public KnuBotAppendTextMessage()
        {
            this.N3MessageType = N3MessageType.KnubotAppendText;
        }

        #endregion

        #region AoMember Properties

        [AoMember(0)]
        public short Unknown1 { get; set; }

        [AoMember(1)]
        public Identity Target { get; set; }

        [AoMember(2)]
        public int Unknown2 { get; set; }

        [AoMember(3, SerializeSize = ArraySizeType.Int32)]
        public string Text { get; set; }

        [AoMember(4)]
        public int Unknown3 { get; set; }

        #endregion
    }
}