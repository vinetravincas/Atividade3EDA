namespace ArvoreBinariaViniciusTravincas
{
	class No
	{
		public No noEsquerdo;
		public char info;
		public No noDireito;

		public No(char info)
		{
			this.noEsquerdo = null;
			this.info = info;
			this.noDireito = null;
		}
	}
}