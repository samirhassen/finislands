using System.ComponentModel.Design.Serialization;

public class Solution {
    int countIslands = 0;
    public int NumIslands(char[][] grid) {
        for(int i = 0; i < grid.Length; i++) {
            for(int j = 0; j < grid[i].Length; j++) {
                countIslands += findIsland(grid, i, j);
            }
        }

        return countIslands;
    }

    public int findIsland(char[][] grid,int i, int j) {
        if (i<0 || j<0 || i >=grid.Length || j>=grid[i].Length || grid[i][j]=='0')
            return 0;

            grid[i][j] = '0';
            findIsland(grid,i+1,j);
            findIsland(grid,i,j+1);
            findIsland(grid,i-1,j);
            findIsland(grid,i,j-1);
        return 1;
    }

    public static void main(string[] args) {
        Solution solution = new Solution();
//        char[][] grid = new char[][]{{[["1","1","1","1","0"],["1","1","0","1","0"],["1","1","0","0","0"],["0","0","0","0","0"]]}}
//        solution.NumIslands(grid);
    }
}