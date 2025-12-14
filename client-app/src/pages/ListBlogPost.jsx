import React, { useEffect, useState } from "react";
import BlogPostService from "../services/BlogPostService";
import Swal from "sweetalert2";
import { useNavigate } from "react-router-dom";
import "bootstrap-icons/font/bootstrap-icons.css";

function ListBlogPost() {
  const [blogposts, setBlogPosts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  const [currentPage, setCurrentPage] = useState(1); 
  const pageSize = 5;

  const navigate = useNavigate();

  const loadBlogPosts = () => {
    setLoading(true);
    setError(null);

    BlogPostService.paginateBlogPosts(currentPage, pageSize)
      .then((response) => {
        const data = response.data; 
        setBlogPosts(data);
        setLoading(false);
      })
      .catch(() => {
        setError("Error fetching blog posts");
        setLoading(false);
      });
  };

  useEffect(() => {
    loadBlogPosts();
  }, [currentPage]);

  const handleDelete = (id) => {
    Swal.fire({
      title: "Are you sure?",
      icon: "warning",
      showCancelButton: true,
      confirmButtonText: "Yes, delete it!",
    }).then((result) => {
      if (result.isConfirmed) {
        BlogPostService.deleteBlogPost(id)
          .then(() => {
            Swal.fire("Deleted!", "The blog post has been deleted.", "success");
            loadBlogPosts();
          })
          .catch(() => {
            Swal.fire("Error", "Failed to delete the blog post.", "error");
          });
      }
    });
  };

  if (loading) return <h3 className="m-4 text-center">Loading blog posts...</h3>;
  if (error) return <p className="m-4 text-center text-danger">{error}</p>;

  return (
    <div className="container mt-4">
      <h2 className="mb-3 text-center text-md-start">
        View the blog posts
      </h2>

      <div className="d-flex justify-content-center justify-content-md-start mb-3">
        <button
          className="btn btn-success btn-sm"
          onClick={() => navigate("/AddBlogPost")}
        >
          <i className="bi bi-plus-lg me-1"></i> Add Blog Post
        </button>
      </div>

      <div className="table-responsive">
        <table className="table table-striped table-bordered">
          <thead>
            <tr>
              <th>Title</th>
              <th>Content</th>
              <th>Author</th>
              <th>Created</th>
              <th>Actions</th>
            </tr>
          </thead>
          <tbody>
            {blogposts.length === 0 ? (
              <tr>
                <td colSpan="5" className="text-center">
                  No blog posts found.
                </td>
              </tr>
            ) : (
              blogposts.map((blogpost) => (
                <tr key={blogpost.id}>
                  <td>{blogpost.title}</td>
                  <td>{blogpost.content}</td>
                  <td>{blogpost.author}</td>
                  <td>{new Date(blogpost.createdAt).toLocaleString()}</td>
                  <td className="d-flex gap-2">
                    <button
                      className="btn btn-sm btn-warning"
                      onClick={() =>
                        navigate(`/EditBlogPost/${blogpost.id}`)
                      }
                    >
                      <i className="bi bi-pencil-fill"></i>
                    </button>
                    <button
                      className="btn btn-sm btn-danger"
                      onClick={() => handleDelete(blogpost.id)}
                    >
                      <i className="bi bi-trash-fill"></i>
                    </button>
                  </td>
                </tr>
              ))
            )}
          </tbody>
        </table>
      </div>

      <div className="d-flex justify-content-center align-items-center mt-3 gap-3">
        <button
          className="btn btn-success btn-sm"
          disabled={currentPage === 1}
          onClick={() => setCurrentPage(currentPage - 1)}
        >
          Previous
        </button>

        <span>Page {currentPage}</span>

        <button
          className="btn btn-success btn-sm"
          onClick={() => setCurrentPage(currentPage + 1)}
        >
          Next
        </button>
      </div>
    </div>
  );
}

export default ListBlogPost;
