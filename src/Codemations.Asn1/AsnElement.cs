﻿using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;

namespace Codemations.Asn1
{
    /// <summary>
    ///   The class representing ASN.1 elements.
    /// </summary>
    public class AsnElement
    {
        /// <summary>
        /// Gets the tag identifying the content.
        /// </summary>
        public Asn1Tag Tag { get; }

        /// <summary>
        /// Gets or sets the content encoded value.
        /// </summary>
        public byte[]? Value { get; set; }

        /// <summary>
        /// Gets the list of child elements.
        /// </summary>
        public List<AsnElement> Elements { get; }

        public AsnElement(Asn1Tag tag): this(tag, new List<AsnElement>())
        {
        }

        public AsnElement(Asn1Tag tag, IEnumerable<AsnElement> elements)
        {
            this.Tag = tag;
            this.Elements = elements.ToList();
        }
    }
}
