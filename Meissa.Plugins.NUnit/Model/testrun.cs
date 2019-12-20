﻿// <copyright file="testrun.cs" company="Automate The Planet Ltd.">
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

namespace Meissa.Core.Model.NUnit
{
    [XmlType(AnonymousType = true)]
    [XmlRoot("test-run", Namespace = "", IsNullable = false)]
    public class testrun
    {
        private string _commandlineField;

        private testrunTestsuite _testsuiteField;

        private int _idField;

        private int _testcasecountField;

        private string _resultField;

        private int _totalField;

        private int _passedField;

        private int _failedField;

        private int _inconclusiveField;

        private int _skippedField;

        private int _assertsField;

        private string _engineversionField;

        private string _clrversionField;

        private string _starttimeField;

        private string _endtimeField;

        private decimal _durationField;

        [XmlElement("command-line")]
        public string commandline
        {
            get
            {
                return _commandlineField;
            }
            set
            {
                _commandlineField = value;
            }
        }

        [XmlElement("test-suite")]
        public testrunTestsuite testsuite
        {
            get
            {
                return _testsuiteField;
            }
            set
            {
                _testsuiteField = value;
            }
        }

        [XmlAttribute]
        public int id
        {
            get
            {
                return _idField;
            }
            set
            {
                _idField = value;
            }
        }

        [XmlAttribute]
        public int testcasecount
        {
            get
            {
                return _testcasecountField;
            }
            set
            {
                _testcasecountField = value;
            }
        }

        [XmlAttribute]
        public string result
        {
            get
            {
                return _resultField;
            }
            set
            {
                _resultField = value;
            }
        }

        [XmlAttribute]
        public int total
        {
            get
            {
                return _totalField;
            }
            set
            {
                _totalField = value;
            }
        }

        [XmlAttribute]
        public int passed
        {
            get
            {
                return _passedField;
            }
            set
            {
                _passedField = value;
            }
        }

        [XmlAttribute]
        public int failed
        {
            get
            {
                return _failedField;
            }
            set
            {
                _failedField = value;
            }
        }

        [XmlAttribute]
        public int inconclusive
        {
            get
            {
                return _inconclusiveField;
            }
            set
            {
                _inconclusiveField = value;
            }
        }

        [XmlAttribute]
        public int skipped
        {
            get
            {
                return _skippedField;
            }
            set
            {
                _skippedField = value;
            }
        }

        [XmlAttribute]
        public int asserts
        {
            get
            {
                return _assertsField;
            }
            set
            {
                _assertsField = value;
            }
        }

        [XmlAttribute("engine-version")]
        public string engineversion
        {
            get
            {
                return _engineversionField;
            }
            set
            {
                _engineversionField = value;
            }
        }

        [XmlAttribute("clr-version")]
        public string clrversion
        {
            get
            {
                return _clrversionField;
            }
            set
            {
                _clrversionField = value;
            }
        }

        [XmlAttribute("start-time")]
        public string starttime
        {
            get
            {
                return _starttimeField;
            }
            set
            {
                _starttimeField = value;
            }
        }

        [XmlAttribute("end-time")]
        public string endtime
        {
            get
            {
                return _endtimeField;
            }
            set
            {
                _endtimeField = value;
            }
        }

        [XmlAttribute]
        public decimal duration
        {
            get
            {
                return _durationField;
            }
            set
            {
                _durationField = value;
            }
        }
    }
}

// ReSharper restore All