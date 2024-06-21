public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    public static float Run(string text) {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' ')) {
            if (item == "+" || item == "-" || item == "*" || item == "/") {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+") {
                    res = op1 + op2;
                }
                else if (item == "-") {
                    res = op1 - op2;
                }
                else if (item == "*") {
                    res = op1 * op2;
                }
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item));
            }
            else if (item == "") {
            }
            else {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}

// Determine the result of the function if the following inputs were provided:
// 5 3 7 + * AFTER ADDING TO THE STACK AND POPPING WHEN ENCOUNTER AN OPERATOR WE GET 50
// 6 2 + 5 3 - / == 4
// Consider possible values for the input parameter text that would result in the function doing the following:
// Display "Invalid Case 1!" = IF STACK IS LESS THAN 2. LETS SAY WE HAVE ONLY ONE INPUT TO MAKE EXAMPLE '3 4 * +'
// Display "Invalid Case 2!" == OCCURS WHEN WE TRY TO DIVIDE BY 0 FOR EXAMPLE 5 0 / INPUT WOULD RESUL TO INVALID CASE 2
// Display "Invalid Case 3!" == OCCURS WHEN AN ITEM IN THE INPUT IS NEITHER A VSLID FLOAT OR OPERATOR FOR EXAMPLE '4 a +' OR '3 4 >' 
// Display "Invalid Case 4!" == THIS OCCURS IF THE STACK DOES NOT CONTAIN ONLY ONE ITEM AFTER THE OPERATIONS ARE DONE. EXAMPLE '5 5' OR '5 3 2 +)