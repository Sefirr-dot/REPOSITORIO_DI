package colaCine;

import java.util.ArrayList;

import java.util.List;


public class ArrayList222 {

	static List<Persona> colaPersonas= new ArrayList<Persona>();
	public static void main(String[] args) {
		int numPersonasCola=(int)(Math.random()*50);
		System.out.println(numPersonasCola);
		crearCola(colaPersonas, numPersonasCola);
		mostratTotal(colaPersonas, numPersonasCola);


	}

	private static void crearCola(List<Persona> colaPersonas2, int numPersonasCola) {
		for (int i = 0; i < numPersonasCola; i++) {
			colaPersonas2.add(generarPersona());

		}
	}
	private static void mostratTotal(List<Persona> colaPersonas2, int numPersonasCola) {
		double total = 0;
		for (int i = 0; i < numPersonasCola; i++) {
			
			int edad= colaPersonas2.get(i).getEdad();
			
			if(edad<11) {
				System.out.println("Persona "+(i+1)+" tiene "+ edad+" años, paga 1€");
				total+=1;

			} else if (edad<18) {
				System.out.println("Persona "+(i+1)+" tiene "+ edad+" años, paga 2.5€");
				total+=2.5;
			} else {
				System.out.println("Persona "+(i+1)+" tiene "+ edad+" años, paga 3.5€");
				total+=3.5;
			}
			
			System.out.println("El total actual es de: "+total+"€");

		}
		
		
	}
	public static Persona generarPersona() {
		int edad = (int) (Math.random()*55+5);
		Persona p1 =new Persona(edad);
		return p1;
	}

}
