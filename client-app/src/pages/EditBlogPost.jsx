import { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import BlogPostService from "../services/BlogPostService";

function EditBlogPost() {
  const { id } = useParams(); 
  const navigate = useNavigate();

  const [title, setTitle] = useState("");
  const [content, setContent] = useState("");
  const [author, setAuthor] = useState("");

  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    BlogPostService.getBlogPostById(id)
      .then((response) => {
        setTitle(response.data.title);
        setContent(response.data.content);
        setAuthor(response.data.author);
        setLoading(false);
      })
      .catch(() => {
        setError("Error loading blog post");
        setLoading(false);
      });
  }, [id]);


  const handleSubmit = (e) => {
    e.preventDefault();

    const updatedPost = { id, title, content, author };

    BlogPostService.editBlogPost(id, updatedPost)
      .then(() => navigate("/ListBlogPost"))
      .catch(() => setError("Error updating blog post"));
  };

  if (loading) {
    return <h3 className="m-4">Loading...</h3>;
  }

  if (error) {
    return <p className="m-4">{error}</p>;
  }

  return (
    <div className="container mt-4">
      <h2 className="mb-3">Edit Blog Post</h2>
      <form onSubmit={handleSubmit}>
        
        <div className="mb-3">
          <label className="form-label">Title</label>
          <input
            type="text"
            className="form-control"
            value={title}
            onChange={(e) => setTitle(e.target.value)}
            required
          />
        </div>

        <div className="mb-3">
          <label className="form-label">Content</label>
          <textarea
            className="form-control"
            value={content}
            onChange={(e) => setContent(e.target.value)}
            rows={5}
            required
          />
        </div>

        <div className="mb-3">
          <label className="form-label">Author</label>
          <input
            type="text"
            className="form-control"
            value={author}
            onChange={(e) => setAuthor(e.target.value)}
            required
          />
        </div>

        <button type="submit" className="btn btn-primary">
          Update
        </button>
      </form>
    </div>
  );
}

export default EditBlogPost;
