package pilas;

public class PilaDinamica<T> {

	private Nodo<T> top;
	private int size;
	
	public PilaDinamica() {
		top = null;
		this.size = 0;
	}
	
	public boolean isEmpty() {	
		return size==0;
		
	}
	
	public boolean isEmpty2() {
		return top==null;
	}
	
	public T top() {
		T holaT = null;
		if(isEmpty()) {
			
		}else {
			holaT=top.getElementoT();
		}
		return holaT;
	}
	
	public T pop() {
		
		if(isEmpty()) {
			return null;
		} else {
			T holaT=top.getElementoT();
			Nodo<T> auxNodo = top.getSiguiente();
			top=auxNodo;
			this.size--;
			return holaT;
		}
	}
	
	public T push(T elementoT) {
		Nodo<T> auxNodo = new Nodo<>(elementoT, top);
		top = auxNodo;
		this.size++;
		return auxNodo.getElementoT();		
	}
	
	public String toString() {
		String resultadoString = "";
		Nodo<T> auxNodo = top;
		while(auxNodo != null) {
			resultadoString += auxNodo.toString();
			auxNodo = auxNodo.getSiguiente();
			
		}
		return resultadoString;
	}
}
