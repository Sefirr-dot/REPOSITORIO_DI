package matrixx;

import java.util.Random;

public class MatricesWapen {

	public static void main(String[] args) {
		
		int hola[][] = {{21,222,1,1,2},
						{23,232,3,3,3}};
		int hola1[][] = {{21,222,1,1,2},
				{23,232,3,3,3}};
		int suma = 0;
		for (int i = 0; i < hola.length; i++) {
			for (int j = 0; j < hola[0].length; j++) {
				suma += hola[i][j]+hola1[i][j];
			}
			
		}
		System.out.println(suma);
		
		
		Random r1 = new Random();
		int numero = r1.nextInt(100);
		System.out.println(numero);
		int[][] hello = new int[20][100];
		
		for (int i = 0; i < hello.length; i++) {
			for (int j = 0; j < hello.length; j++) {
				if(j==i) {
					hello[i][j]=i;
				}
			}
			
		}
		for (int i = 0; i < hello.length; i++) {
			for (int j = 0; j < hello[i].length; j++) {
				System.out.print(hello[i][j]+" ");
			}
			System.out.println();
			}
		
	}

}