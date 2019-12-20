﻿// <copyright file="TestRunResultSummary.cs" company="Automate The Planet Ltd.">
// Copyright 2020 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://bellatrix.solutions/</site>

// <auto-generated/>
// ReSharper disable All

using System.Xml.Serialization;

namespace Meissa.Plugins.MSTest.Model
{
   
    [XmlType(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunResultSummary
    {
        private TestRunResultSummaryCounters countersField;

        private string outcomeField;

        
        public TestRunResultSummaryCounters Counters
        {
            get
            {
                return this.countersField;
            }
            set
            {
                this.countersField = value;
            }
        }

        
        [XmlAttribute()]
        public string outcome
        {
            get
            {
                return this.outcomeField;
            }
            set
            {
                this.outcomeField = value;
            }
        }
    }
}
// ReSharper enable all