using System;
using System.Collections.Generic;

namespace TrabajoFinalComplejidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Arboles ");
            Console.WriteLine(" ------- ");

            ArbolGeneral<string> a = new ArbolGeneral<string>(" a ");
            ArbolGeneral<string> b = new ArbolGeneral<string>(" b ");
            ArbolGeneral<string> c = new ArbolGeneral<string>(" c ");
            ArbolGeneral<string> d = new ArbolGeneral<string>(" d ");
            ArbolGeneral<string> e = new ArbolGeneral<string>(" e ");
            ArbolGeneral<string> f = new ArbolGeneral<string>(" f ");
            ArbolGeneral<string> g = new ArbolGeneral<string>(" g ");
            ArbolGeneral<string> h = new ArbolGeneral<string>(" h ");
            ArbolGeneral<string> i = new ArbolGeneral<string>(" i ");
            ArbolGeneral<string> j = new ArbolGeneral<string>(" j ");
            ArbolGeneral<string> k = new ArbolGeneral<string>(" k ");
            ArbolGeneral<string> l = new ArbolGeneral<string>(" l ");
            ArbolGeneral<string> m = new ArbolGeneral<string>(" m ");
            ArbolGeneral<string> n = new ArbolGeneral<string>(" n ");
            ArbolGeneral<string> o = new ArbolGeneral<string>(" o ");
            ArbolGeneral<string> p = new ArbolGeneral<string>(" p ");
            ArbolGeneral<string> q = new ArbolGeneral<string>(" q ");
            ArbolGeneral<string> r = new ArbolGeneral<string>(" r ");
            ArbolGeneral<string> s = new ArbolGeneral<string>(" s ");
            ArbolGeneral<string> t = new ArbolGeneral<string>(" t ");

            a.agregarHijo(b);
            a.agregarHijo(c);
            a.agregarHijo(d);
            b.agregarHijo(e);
            b.agregarHijo(f);
            b.agregarHijo(g);
            f.agregarHijo(l);
            l.agregarHijo(m);
            m.agregarHijo(o);
            g.agregarHijo(n);
            c.agregarHijo(h);
            c.agregarHijo(i);
            c.agregarHijo(j);
            i.agregarHijo(p);
            p.agregarHijo(q);
            q.agregarHijo(r);
            r.agregarHijo(s);
            s.agregarHijo(t);
            d.agregarHijo(k);

            Console.WriteLine(" La altura del árbol " + a.getDatoRaiz() + " es: " + a.altura());
            Console.WriteLine(" La nivel del árbol " + r.getDatoRaiz()+ " es: " + a.nivel(" r "));
        }
    }
}
