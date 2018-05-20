﻿using ESISharp.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESISharp.Paths.Authenticated.Alliances
{
    public class Main : Public.Alliances
    {
        private readonly Contacts _Contacts;

        public Contacts Contacts => _Contacts;

        internal Main(EsiConnection esiconnection) : base(esiconnection)
        {
            _Contacts = new Contacts(esiconnection);
        }
    }
}