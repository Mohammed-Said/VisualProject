﻿using BookStore.Admin.Forms;
using BookStore.Application.Services;
using BookStore.Models;
using BookStore.User.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Presentation.AutoFag;
using static System.Reflection.Metadata.BlobBuilder;
using Autofac;

namespace BookStore.User.Forms
{
  public partial class BooksForm : Form
  {
    int customerId;
    int pageNum;
    int maxPageNum;

    Autofac.IContainer connectionBook;
    IBookService BookService;
    public BooksForm(int id)
    {
      InitializeComponent();
      connectionBook = AutoFag.RegisterBook();
      BookService = connectionBook.Resolve<IBookService>();

      pageNum = 1;
      maxPageNum = BookService.GetCount();
      customerId = id;

      ShowButtons();
      ShowBooks(BookService.GetAllPagination(10, pageNum));

    }
    void ShowButtons()
    {
      if (maxPageNum == 1)
      {
        prevBtn.Visible = false;
        nextBtn.Visible = false;
      }
      else if (pageNum == 1)
      {
        prevBtn.Visible = false;
        nextBtn.Visible = true;
      }
      else if (pageNum == maxPageNum)
      {
        prevBtn.Visible = true;
        nextBtn.Visible = false;
      }
      else
      {
        prevBtn.Visible = true;
        nextBtn.Visible = true;
      }
    }
    void ShowBooks(List<Book> books)
    {
      mainPanel.Controls.Clear();
      foreach (var book in books)
      {
        var bookControl = new BookControl(customerId);
        bookControl.BookName = book.Name;
        bookControl.BookPrice = book.Price.ToString() + " LE";
        bookControl.BookImage = Image.FromFile(Path.GetFullPath($"..\\..\\..\\Images\\{book.BookImg}"));
        bookControl.id = book.Id;
        mainPanel.Controls.Add(bookControl);
      }
    }
    private void prevBtn_Click(object sender, EventArgs e)
    {
      pageNum--;
      ShowButtons();
      ShowBooks(BookService.GetAllPagination(10, pageNum));
    }

    private void nextBtn_Click(object sender, EventArgs e)
    {
      pageNum++;
      ShowButtons();
      ShowBooks(BookService.GetAllPagination(10, pageNum));
    }

   
  }


}
