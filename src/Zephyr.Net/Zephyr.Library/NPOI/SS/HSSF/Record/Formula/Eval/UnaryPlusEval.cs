/*
* Licensed to the Apache Software Foundation (ASF) Under one or more
* contributor license agreements.  See the NOTICE file distributed with
* this work for Additional information regarding copyright ownership.
* The ASF licenses this file to You Under the Apache License, Version 2.0
* (the "License"); you may not use this file except in compliance with
* the License.  You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed Under the License is distributed on an "AS Is" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations Under the License.
*/

namespace NPOI.HSSF.Record.Formula.Eval
{
    using System;
    using NPOI.HSSF.Record.Formula;
    using NPOI.HSSF.Record.Formula.Functions;
    /**
     * @author Amol S. Deshmukh &lt; amolweb at ya hoo dot com &gt;
     *  
     */
    public class UnaryPlusEval : Fixed1ArgFunction
    {

        public static Function instance = new UnaryPlusEval();
    	
	    private UnaryPlusEval() {
	    }

        public override ValueEval Evaluate(int srcCellRow, int srcCellCol, ValueEval arg0)
        {
            double d;
            try
            {
                ValueEval ve = OperandResolver.GetSingleValue(arg0, srcCellRow, srcCellCol);
                if (ve is BlankEval)
                {
                    return NumberEval.ZERO;
                }
                if (ve is StringEval)
                {
                    // Note - asymmetric with UnaryMinus
                    // -"hello" Evaluates to #VALUE!
                    // but +"hello" Evaluates to "hello"
                    return ve;
                }
                d = OperandResolver.CoerceValueToDouble(ve);
            }
            catch (EvaluationException e)
            {
                return e.GetErrorEval();
            }
            return new NumberEval(+d);
        }
    }
}