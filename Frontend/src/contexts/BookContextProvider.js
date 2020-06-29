import React, { createContext, useState, useEffect } from 'react'

export const BookContext = createContext()

const BookContextProvider = (props) => {

  const [books, setBooks] = useState([])

  //Get Data from API
  const getBooks = async () => {
    let res = await fetch('/api/book')
    res = await res.json()
    setBooks(res)
    console.log(res);
    
  }

  useEffect(()=>{
    getBooks()
  }, [])

  const values = {
    books
  }

  return (
    <BookContext.Provider value={values}>
      {props.children}
    </BookContext.Provider>
  )
}

export default BookContextProvider
