﻿//
//   Copyright 2015 Blu Age Corporation - Plano, Texas
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
using System.Collections.Generic;
using Summer.Batch.Extra.Ebcdic;

namespace Summer.Batch.CoreTests.Ebcdic.Test
{
    public class SimpleEbcdicMapper : AbstractEbcdicReaderMapper<Simple>
    {
        private const int LongValue = 0;
        private const int FloatValue = 1;
        private const int Date = 2;
        private const int BooleanValue = 3;

        public override string DistinguishedPattern { get { return null; } }

        public override Simple Map(IList<object> values, int itemCount)
        {
            Simple record = new Simple
            {
                LongValue = (long) ((decimal) values[LongValue]),
                FloatValue = (float) ((decimal) values[FloatValue]),
                Date = ParseDate(values[Date]),
                BooleanValue = ParseBoolean(values[BooleanValue])
            };
            return record;
        }
    }
}