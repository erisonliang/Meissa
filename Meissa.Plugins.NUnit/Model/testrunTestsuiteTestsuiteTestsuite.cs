﻿// <copyright file="testrunTestsuiteTestsuiteTestsuite.cs" company="Automate The Planet Ltd.">
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
using System.Xml.Serialization;

namespace Meissa.Core.Model.NUnit
{
    [XmlType(AnonymousType = true)]
    public class testrunTestsuiteTestsuiteTestsuite
    {
        private testrunTestsuiteTestsuiteTestsuiteFailure _failureField;

        private testrunTestsuiteTestsuiteTestsuiteTestcase[] _testcaseField;

        private string _typeField;

        private string _idField;

        private string _nameField;

        private string _fullnameField;

        private string _classnameField;

        private string _runstateField;

        private int _testcasecountField;

        private string _resultField;

        private string _starttimeField;

        private string _endtimeField;

        private decimal _durationField;

        private int _totalField;

        private int _passedField;

        private int _failedField;

        private int _warningsField;

        private int _inconclusiveField;

        private int _skippedField;

        private int _assertsField;

        private string _siteField;

        public testrunTestsuiteTestsuiteTestsuiteFailure failure
        {
            get => _failureField;
            set => _failureField = value;
        }

        [XmlElement("test-case")]
        public testrunTestsuiteTestsuiteTestsuiteTestcase[] testcase
        {
            get => _testcaseField;
            set => _testcaseField = value;
        }

        [XmlAttribute]
        public string type
        {
            get => _typeField;
            set => _typeField = value;
        }

        [XmlAttribute]
        public string id
        {
            get => _idField;
            set => _idField = value;
        }

        [XmlAttribute]
        public string name
        {
            get => _nameField;
            set => _nameField = value;
        }

        [XmlAttribute]
        public string fullname
        {
            get => _fullnameField;
            set => _fullnameField = value;
        }

        [XmlAttribute]
        public string classname
        {
            get => _classnameField;
            set => _classnameField = value;
        }

        [XmlAttribute]
        public string runstate
        {
            get => _runstateField;
            set => _runstateField = value;
        }

        [XmlAttribute]
        public int testcasecount
        {
            get => _testcasecountField;
            set => _testcasecountField = value;
        }

        [XmlAttribute]
        public string result
        {
            get => _resultField;
            set => _resultField = value;
        }

        [XmlAttribute("start-time")]
        public string starttime
        {
            get => _starttimeField;
            set => _starttimeField = value;
        }

        [XmlAttribute("end-time")]
        public string endtime
        {
            get => _endtimeField;
            set => _endtimeField = value;
        }

        [XmlAttribute]
        public decimal duration
        {
            get => _durationField;
            set => _durationField = value;
        }

        [XmlAttribute]
        public int total
        {
            get => _totalField;
            set => _totalField = value;
        }

        [XmlAttribute]
        public int passed
        {
            get => _passedField;
            set => _passedField = value;
        }

        [XmlAttribute]
        public int failed
        {
            get => _failedField;
            set => _failedField = value;
        }

        [XmlAttribute]
        public int warnings
        {
            get => _warningsField;
            set => _warningsField = value;
        }

        [XmlAttribute]
        public int inconclusive
        {
            get => _inconclusiveField;
            set => _inconclusiveField = value;
        }

        [XmlAttribute]
        public int skipped
        {
            get => _skippedField;
            set => _skippedField = value;
        }

        [XmlAttribute]
        public int asserts
        {
            get => _assertsField;
            set => _assertsField = value;
        }

        [XmlAttribute]
        public string site
        {
            get => _siteField;
            set => _siteField = value;
        }
    }
}
