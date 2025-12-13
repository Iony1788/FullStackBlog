import React from "react";
import { Link } from "react-router-dom";
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import { FaHome, FaPenFancy } from 'react-icons/fa';
import '../styles/Header.css'; 

function Header() {
  return (
    <header>
      <nav className="navbar navbar-expand-md navbar-dark sticky-top" style={{ backgroundColor: 'rgb(25, 62, 135)' }}>
        <div className="container">
          <Link className="navbar-brand fw-bold" to="/">Blog Post</Link>

          <button
            className="navbar-toggler"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#navbarNav"
            aria-controls="navbarNav"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon"></span>
          </button>

          <div className="collapse navbar-collapse" id="navbarNav">
            <ul className="navbar-nav ms-auto text-center">
              <li className="nav-item">
                <Link className="nav-link d-flex align-items-center gap-1 nav-link-hover" to="/">
                  <FaHome className="me-1" /> Home
                </Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link d-flex align-items-center gap-1 nav-link-hover" to="/ListBlogPost">
                  <FaPenFancy className="me-1" /> Blog Posts
                </Link>
              </li>
            </ul>
          </div>
        </div>
      </nav>
    </header>
  );
}

export default Header;
