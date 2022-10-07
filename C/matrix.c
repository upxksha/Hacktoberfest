#include <stdio.h>

int main(int argc, char const *argv[]) {
  int n;
  printf("What's the dimension size of the square matrix? ");
  scanf(" %d", &n); // Inputing dimension size of the matrix
  int matrix1[n][n], matrix2[n][n]; // Declaring matrices
  int matrix_sum[n][n];
  int matrix_product[n][n], temp_product[n];
  int matrix1_transpose[n][n], matrix2_transpose[n][n];
  // Inputing values for matrix 1
  printf("Enter the values for the first matrix:\n");
  for (int i=0;i<n;i++) {
    for(int j=0;j<n;j++){
      scanf(" %d", &matrix1[i][j]);
    }
  }
  // Inputing values for matrix 2
  printf("Enter the values for the second matrix:\n");
  for (int i=0;i<n;i++) {
    for(int j=0;j<n;j++){
      scanf(" %d", &matrix2[i][j]);
    }
  }
  // Calculating matrix sum
  for (int i=0;i<n;i++) {
    for(int j=0;j<n;j++){
      matrix_sum[i][j] = matrix1[i][j]+matrix2[i][j];
    }
  }
  // Display the matrix sum
  printf("The matrix sum:\n");
  for (int i=0;i<n;i++) {
    for(int j=0;j<n;j++){
      printf(" %d", matrix_sum[i][j]);
    }
    printf("\n");
  }
  // Calculating the matrix product
    for (int i=0;i<n;i++) {
      for(int j=0;j<n;j++){
        matrix_product[i][j]=0;
        for(int k=0;k<n;k++){
          matrix_product[i][j] += matrix1[i][k]*matrix2[k][j];
        }
      }
    }
  // Displaying the matrix product
  printf("The matrix product:\n");
  for (int i=0;i<n;i++) {
    for(int j=0;j<n;j++){
      printf(" %d", matrix_product[i][j]);
    }
    printf("\n");
  }
  // Transpose the matrix
  for(int i=0;i<n;i++){
    for(int j=0;j<n;j++){
      matrix1_transpose[j][i]=matrix1[i][j];
      matrix2_transpose[j][i]=matrix2[i][j];
    }
  }
  // Displaying the transposed matrices
  printf("Matrix 1 transposed:\n");
  for (int i=0;i<n;i++) {
    for(int j=0;j<n;j++){
      printf(" %d", matrix1_transpose[i][j]);
    }
    printf("\n");
  }
  printf("Matrix 2 transposed:\n");
  for (int i=0;i<n;i++) {
    for(int j=0;j<n;j++){
      printf(" %d", matrix2_transpose[i][j]);
    }
    printf("\n");
  }
  return 0;
}
