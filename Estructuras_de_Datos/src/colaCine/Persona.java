package colaCine;

public class Persona {

	private int edad;

	public Persona(int edad) {
		super();
		this.edad = edad;
	}

	public int getEdad() {
		return edad;
	}

	public void setEdad(int edad) {
		this.edad = edad;
	}

	@Override
	public String toString() {
		return "Persona [edad=" + edad + "]";
	}
	
	
}
