using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblems.Chapter1
{
    class RotateMatrix90Degrees
    {
        public int[,] RotateMatrixClockwise90Degrees(int[,] matrix, int n)
        {
            for (int layer = 0; layer < n / 2; layer++)
            {
                int layerStart = layer; //starts at 0. Only one part of the coordiante
                int layerLength = n - layer - 1; // layer lentgth - layers already processed - 1 (to account for 0 index)

                for (int layerIndex = layerStart; layerIndex < layerLength; layerIndex++)
                {
                    int offset = layerIndex - layerStart; // for each layer, there is one less item
                                                          // thus -1 from last.

                    // Store the first item [0,0]
                    int temp = matrix[layerStart, layerIndex];

                    // Move item at bottom left corner to top left corner
                    matrix[layerStart, layerIndex] = matrix[layerLength - offset, layerStart];

                    // Move item from bottom right corner to bottom left corner
                    matrix[layerLength - offset, layerStart] = matrix[layerLength, layerLength - offset];

                    // Move item from top right corner to bottom right corner
                    matrix[layerLength, layerLength - offset] = matrix[layerIndex, layerLength];

                    // Stored item to top right
                    matrix[layerIndex, layerLength] = temp;
                }
            }
            return matrix;
        }

        public void Print(int[,] matrix, int length, int width)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }
        }
    }
}
