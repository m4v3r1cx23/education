var arrayA = generateArray(1);
var arrayB = generateArray(2);

var sum = addArrays(arrayA, arrayB);

displayArray(sum);

static int[,] generateArray(int value) {
    int[,] array = new int[10, 10];

    for (var i = 0; i < 10; i++) {
        for (var j = 0; j < 10; j++) {
            array[i, j] = value;
        }
    }

    return array;
}

static int[,] addArrays(int[,] arrayA, int[,] arrayB) {
    int[,] array = new int[10, 10];

    for (var i = 0; i < 10; i++) {
        for (var j = 0; j < 10; j++) {
            array[i, j] = arrayA[i, j] + arrayB[i, j];
        }
    }

    return array;
}

static void displayArray(int[,] array) {
    for (var i = 0; i < 10; i++) {
        for (var j = 0; j < 10; j++) {
            Console.Write(array[i, j]);
        }

        Console.WriteLine();
    }
}