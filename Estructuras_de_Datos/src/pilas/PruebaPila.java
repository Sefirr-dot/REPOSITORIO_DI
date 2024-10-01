package pilas;

public class PruebaPila {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("Mi pila Dinamica");
		PilaDinamica<Integer> pilaNumeros=new PilaDinamica<Integer>();
		System.out.println("La pila esta vacia??");
		System.out.println(pilaNumeros.isEmpty());
		pilaNumeros.push(10);
		pilaNumeros.push(12);
		pilaNumeros.push(20);
		
		System.out.println(pilaNumeros.isEmpty());
		System.out.println(pilaNumeros.toString());
		System.out.println(pilaNumeros.pop());
		System.out.println(pilaNumeros.pop());
		System.out.println(pilaNumeros.push(122));
		System.out.println(pilaNumeros.pop());
		System.out.println(pilaNumeros.pop());
	}

}
