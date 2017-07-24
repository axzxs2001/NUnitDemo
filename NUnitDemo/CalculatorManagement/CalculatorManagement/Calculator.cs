﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorManagement
{
    /// <summary>
    /// 计算器
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// 加法运算
        /// </summary>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public double Plus(params double[] parameters)
        {
            var result = 0d;
            foreach(var parameter in parameters)
            {
                result += parameter;
            }
            return result;
        }
        /// <summary>
        /// 减法运算
        /// </summary>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public double Minus(params double[] parameters)
        {
            if (parameters.Length == 0)
            {
                return 0;
            }
            else
            {
                var result = parameters[0];
                for(var i=1;i<parameters.Length;i++)
                {
                    result -= parameters[i];
                }
                return result;
            }
        }
        /// <summary>
        /// 乘法运算
        /// </summary>
        /// <param name="parameters">参数</param>
        /// <returns></returns>
        public double Multiply(params double[] parameters)
        {
            var result = 0d;
            foreach (var parameter in parameters)
            {
                result *= parameter;
            }
            return result;
        }
        /// <summary>
        /// 除法运算
        /// </summary>
        /// <param name="parameters
        public double Divide(params double[] parameters)
        {
            if (parameters.Length == 0)
            {
                return 0;
            }
            else
            {
                var result = parameters[0];
                for (var i = 1; i < parameters.Length; i++)
                {
                    if (parameters[i] == 0)
                    {
                        throw new DivideByZeroException($"第{i + 1}个参数不能为零");
                    }
                    else
                    {
                        result /= parameters[i];
                    }
                }
                return result;
            }
        }
    }
}
