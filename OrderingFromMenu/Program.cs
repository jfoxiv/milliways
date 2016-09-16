/*
 * John Fox - MIS 218 Summer 2016 - Exercise 15.9
 * 
 * First of all, I have to say that I really enjoy the fact
 * that this project involving menu items appears in the
 * chapter of the book dedicated to--among other things--
 * menus!
 * 
 * The weirdest thing I encountered concerned the comboboxes;
 * when I performed the data-binding between them and their
 * corresponding dictionaries (see Form1_Load() if you want
 * to see how I did that), the combobox's SelectedIndexChanged
 * handler was triggered--which in turn triggered my updating
 * of the order-related textboxes. Kinda glitchy, right? I
 * resolved it by addig code such that the textboxes wouldn't
 * be updated if the comboboxes hadn't yet been databound. lf
 * you want to see how this was done, see my usage of 
 * "comboBoxesReloaded" boolean within Form1's partial
 * declaration in Form1.cs. Simple solution, but I don't
 * mind telling you that it had me scratching my head
 * a while.
 * 
 * There's some duplicated code in here that I'm
 * certain could be eliminated, possibly by exploiting
 * polymorphism or interfaces, but given that we weren't
 * assigned that chapter for reading (although I did
 * read it), I suspect I'm on solid ground here.
 * 
 * I had a great breakthrough while writing this.
 * In a few of the previous exercises, I've seen a need
 * for static instance variables, but despite a fair
 * amount of effort, I couldn't find out how to access
 * such statics. This lead to the use of global variables,
 * which neither of us was crazy about it. So I took
 * another stab at finding the information, and ultimately
 * I was successful. I never saw a written example of how to
 * access a static member from a non-static class, but after
 * I sufficiently clued in on the non-instantiation of
 * static members, I realized what to do, tested my idea,
 * and saw it work. Very satisfying, but it's bizarre to
 * me that I took so long to catch the clues. It's also
 * strange that all my Googling about "static members from
 * non-static classes" didn't turn up (at least in the first
 * page of results) even one example of the proper
 * methodology. So yeah, pretty cool!
 * 
 * Did we cover LINQ in the first C# class? I feel like
 * we didn't. I'm curious because I think LINQ could
 * have been used for this project. And as mentioned
 * earlier, I used dictionaries bound to comboboxes.
 * I can't help but wonder if there's any particular
 * experience-based expectation on what sort of approach
 * would be used for data handling in this project.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingFromMenu {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
