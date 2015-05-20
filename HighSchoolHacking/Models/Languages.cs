﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HighSchoolHacking.Models;

namespace HighSchoolHacking.Models
{
    public static class Languages
    {
        public static string SharedViewStart = "~/Views/Shared/Pages/";

        public static Language Python = new Language
        {
            Name = "Python",
            NameLower = "python",
            Color = "green",
            ParenthesisLeft = "(",
            ParenthesisRight = ")",
            Semicolon = "",
            Commentor = "#",
            ConditionalLeft = " ",
            ConditionalRight = ":",
            ConditionalContinueLeft = "",
            ConditionalContinueRight = ": ",
            ConditionalEnd = null,
            BooleanTrue = "True",
            BooleanFalse = "False",
            If = "if",
            Else = "else",
            Elif = "elif",
            Equals = "=",
            And = "and",
            Or = "or",
            StringAnyApostrophes = true,
            StringConcatenationBetween = "+",
            ArrayName = "List",
            ArrayNamePlural = "Lists",
            DictionaryName = "Dictionary",
            DictionaryNamePlural = "Dictionaries",
            FunctionDefine = "def ",
            FunctionRight = ":",
            FunctionEnd = null,
            ClassStart = "class ",
            ClassConstructor = "__init__",
            ClassFunctionsTakeThis = true,
            ClassThis = "self",
            LengthName = "len",
            LengthIsProperty = false,
            NativeExponents = false,
            DictionaryKeyInCheck = true,
            DictionaryKeyCheckName = " in ",
            DictionaryIterator = ".items()",
            DictionaryIterateAsPair = true,
            DirectArrayLoops = true,
            FunctionsFirstClass = true,
            PrintFunction = "print",
            AppendFunction = "append",
            VariableDeclare = "",
            UndefinedError = "NameError: name ",
            CustomPages = new HashSet<string> { "ForLoops", "Dictionaries", "WingIDE", "FileIO", "Simplebot", "WordSpam" },
            PageAliases = new Dictionary<string, string>
            {
                { "Arrays", "Lists" }
            }
        };

        public static Language JavaScript = new Language
        {
            Name = "JavaScript",
            NameLower = "javascript",
            Color = "blue",
            ParenthesisLeft = "(",
            ParenthesisRight = ")",
            ConditionalLeft = " (",
            ConditionalRight = ") {",
            ConditionalContinueLeft = "} ",
            ConditionalContinueRight = " { ",
            ConditionalEnd = "}",
            BooleanTrue = "true",
            BooleanFalse = "false",
            Semicolon = ";",
            Commentor = "//",
            If = "if",
            Else = "else",
            Elif = "else if",
            Equals = "=",
            And = "&&",
            Or = "||",
            StringAnyApostrophes = true,
            StringConcatenationBetween = "+",
            ArrayName = "Array",
            ArrayNamePlural = "Arrays",
            DictionaryName = "Object",
            DictionaryNamePlural = "Objects",
            FunctionDefine = "function ",
            FunctionRight = " {",
            FunctionEnd = "}",
            ClassEnd = "}",
            ClassThis = "this",
            LengthName = "length",
            StrictIntegers = false,
            CanConcatenateNumbers = true,
            LengthIsProperty = true,
            DictionaryKeyInCheck = false,
            DictionaryKeyCheckName = "hasOwnProperty",
            FunctionsFirstClass = true,
            FunctionsAsVariables = true,
            PrintFunction = "console.log",
            AppendFunction = "push",
            VariableDeclare = "var ",
            UndefinedError = "Uncaught ReferenceError:",
            CustomPages = new HashSet<string> { "DeveloperTools", "NameTypos", "CookieClicker", "BouncingElements", "RandomExclamations", "ChromeExtensions" },
            PageAliases = new Dictionary<string, string>
            {
                { "Dictionaries", "Objects" }
            }
        };

        public static Language LOLCODE = new Language
        {
            Name = "LOLCODE",
            NameLower = "lolcode",
            Color = "red",
            ParenthesisLeft = " ",
            ParenthesisRight = " ",
            ConditionalAfter = true,
            ConditionalLeft = "",
            ConditionalRight = "",
            ConditionalContinueLeft = null,
            ConditionalContinueRight = null,
            BooleanTrue = "WIN",
            BooleanFalse = "FAIL",
            Semicolon = "",
            Commentor = "  BTW",
            If = ", O RLY?",
            Else = "",
            Elif = "MEBBE ",
            WhenTrue = "YA RLY, ",
            WhenFalse = "NO WAI, ",
            EndIf = "OIC",
            Equals = "ITZ",
            And = "",
            Or = "",
            StringAnyApostrophes = false,
            StringConcatenationStart = "SMOOSH ",
            StringConcatenationBetween = "AN",
            StringConcatenationEnd = " MKAY",
            ArrayName = "Array",
            ArrayNamePlural = "Arrays",
            DictionaryName = "Object",
            DictionaryNamePlural = "Objects",
            FunctionDefine = "function ",
            FunctionRight = " {",
            FunctionEnd = "}",
            LengthName = "length",
            StrictIntegers = true,
            CanConcatenateNumbers = true,
            LengthIsProperty = true,
            DictionaryKeyInCheck = false,
            DictionaryKeyCheckName = "hasOwnProperty",
            FunctionsFirstClass = true,
            FunctionsAsVariables = true,
            PrintFunction = "VISIBLE",
            AppendFunction = "push",
            VariableDeclare = "I HAS A ",
            UndefinedError = "MachineError: Reference to undefined variable:",
            FancyNumberMath = (string left, string operation, string right) =>
            {
                string before = "";

                switch (operation)
                {
                    case "+":
                        before = "SUM OF";
                        break;
                    case "-":
                        before = "DIFF OF";
                        break;
                    case "*":
                        before = "PRODUKT OF";
                        break;
                    case "/":
                        before = "QUOSHUNT OF";
                        break;
                    case "%":
                        before = "MOD OF";
                        break;
                    case ">":
                        before = "BIGGR OF";
                        break;
                    case "<":
                        before = "SMALLR OF";
                        break;
                    case "<=":
                        before = "BOTH SAEM " + left + " AN BIGGR OF";
                        break;
                    case ">=":
                        before = "BOTH SAEM " + left + " AN SMALLR OF";
                        break;
                    case "==":
                        before = "BOTH SAEM";
                        break;
                    case "!=":
                        before = "DIFFRINT";
                        break;
                }

                return before + " " + left + " AN " + right;
            },
            CustomPages = new HashSet<string> { "Learn" },
            PageAliases = new Dictionary<string, string> { }
        };

        public static Dictionary<string, Language> LanguagesByName = new Dictionary<string, Language>
        {
            { "Python", Python },
            { "JavaScript", JavaScript }
        };

        public static string[] LessonPages = { "Learn", "Hello World", "Variables", "Comments", "Strings", "Numbers", "Conditionals", "While Loops", "Arrays", "For Loops", "Dictionaries", "Functions", "Recursion" };

        public static string GetSharedPage(string lesson)
        {
            return SharedViewStart + lesson + ".cshtml";
        }

        public static string GetSectionPage(string section, string lesson)
        {
            return "~/Views/" + section + "/" + lesson + ".cshtml";
        }
    }
}