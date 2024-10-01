package pilas;

public class Nodo<T> {
	
	private T elementoT;
	private Nodo<T> siguiente;
	
	public Nodo(T elementoT, Nodo<T> siguiente) {
		super();
		this.elementoT = elementoT;
		this.siguiente = siguiente;
	}
	public Nodo() {
		siguiente = null;
	}

	public Nodo(T elementoT) {
		super();
		siguiente=null;
		this.elementoT = elementoT;
	}


	public T getElementoT() {
		return elementoT;
	}

	public void setElementoT(T elementoT) {
		this.elementoT = elementoT;
	}

	public Nodo<T> getSiguiente() {
		return siguiente;
	}

	public void setSiguiente(Nodo<T> siguiente) {
		this.siguiente = siguiente;
	}
	
	
}
